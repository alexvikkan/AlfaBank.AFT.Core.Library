﻿using System.Data;

namespace AlfaBank.AFT.Core.Data.DataBase.DbCommandParameter
{
    public class DbCommandParameter
    {
        public DbCommandParameter(string name, DbType databaseType, object value)
        {
            Name = name;
            DbType = databaseType;
            Value = value;
        }

        public DbCommandParameter()
        {
        }

        public string Name { get; set; }
        public DbType DbType { get; set; }
        public object DriverDbType { get; set; }
        public object Value { get; set; }
    }
}
