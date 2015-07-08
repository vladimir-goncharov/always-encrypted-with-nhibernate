using NHibernate;
using NHibernate.Mapping.ByCode.Conformist;

namespace AlwaysEncryptedApp
{
    public class CustomerMap : ClassMapping<Customer>
    {
        public CustomerMap()
        {
            Table("Customers");
            Id(x => x.Id);
            Property(m => m.Name, m => m.Type(NHibernateUtil.String));
            Property(m => m.PersonalId, m => m.Type(NHibernateUtil.AnsiString));
        }
    }
}