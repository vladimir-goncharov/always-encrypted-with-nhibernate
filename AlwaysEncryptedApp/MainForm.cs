using System;
using System.Reflection;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Dialect;
using NHibernate.Mapping.ByCode;
using NHibernate.Type;

namespace AlwaysEncryptedApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private ISessionFactory SessionFactory { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SessionFactory = BuildSessionFactory();
            gridCustomers.AutoGenerateColumns = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var session = SessionFactory.OpenSession())
            {
                // NOTE: you need to provide length of parameters explicitly, otherwise NHibernate would take the maximum allowed length 
                // which would cause the 'Operand type clash' error message on the SQL server
                session.CreateSQLQuery("exec sp_add_customer :name, :personalId")
                       .SetParameter("name", txtName.Text, TypeFactory.GetStringType(60))
                       .SetParameter("personalId", txtPersonalId.Text, TypeFactory.GetAnsiStringType(8))
                       .ExecuteUpdate();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (var session = SessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    var customers = session.QueryOver<Customer>()
                                           .List<Customer>();

                    gridCustomers.DataSource = customers;
                }
            }
        }

        private void btnLoadById_Click(object sender, EventArgs e)
        {
            using (var session = SessionFactory.OpenSession())
            {
                using (session.BeginTransaction())
                {
                    var customers = session.QueryOver<Customer>()
                                           .Where(c => c.PersonalId == txtLoadByPersonalId.Text)
                                           .List<Customer>();

                    gridCustomers.DataSource = customers;
                }
            }
        }

        private static ISessionFactory BuildSessionFactory()
        {
            var configuration = new Configuration();

            configuration.SetProperty("connection.driver_class",
                                      "AlwaysEncryptedApp.SizeAwareSqlClientDriver, AlwaysEncryptedApp");

            configuration.DataBaseIntegration(db =>
            {
                db.Dialect<MsSql2012Dialect>();
                db.ConnectionString =
                    "Data Source=MyDbServer; Initial Catalog=MyDatabase; Integrated Security=true; Column Encryption Setting=enabled";
            });

            configuration.AddDeserializedMapping(CompileHbmMappings(), "NHSchema");

            return configuration.BuildSessionFactory();
        }

        private static HbmMapping CompileHbmMappings()
        {
            var mapper = new ModelMapper();

            mapper.AddMappings(Assembly.GetAssembly(typeof (MainForm))
                                       .GetExportedTypes());

            return mapper.CompileMappingForAllExplicitlyAddedEntities();
        }
    }
}