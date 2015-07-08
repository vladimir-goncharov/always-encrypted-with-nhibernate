using System.Data;
using NHibernate.Driver;
using NHibernate.SqlTypes;

namespace AlwaysEncryptedApp
{
    public class SizeAwareSqlClientDriver : SqlClientDriver
    {
        protected override void InitializeParameter(IDbDataParameter dbParam, string name, SqlType sqlType)
        {
            base.InitializeParameter(dbParam, name, sqlType);

            if (sqlType.LengthDefined)
            {
                dbParam.Size = sqlType.Length;
            }
        }
    }
}