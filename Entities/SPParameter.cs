using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Entities
{
    public class SPParameter
    {
        private SqlParameter parameter;

        public SqlParameter Parameter
        {
            get { return parameter; }
        }

        public String Name
        {
            get { return parameter.ParameterName; }
            set { parameter.ParameterName = CheckName(value); }
        }

        public Object Value
        {
            get { return parameter.Value; }
            set
            {
                if (value == null)
                    throw new Exception("Null value. Use DBNull.");

                parameter.Value = value;
            }
        }

        public DbType DbType
        {
            get { return parameter.DbType; }
            set { parameter.DbType = value; }
        }

        public int Size
        {
            get { return parameter.Size; }
            set { parameter.Size = value; }
        }

        public bool IsNullable
        {
            get { return parameter.IsNullable; }
            set { parameter.IsNullable = value; }
        }

        public bool IsOutput
        {
            get { return parameter.Direction == ParameterDirection.Output; }
            set { parameter.Direction = ParameterDirection.Output; }
        }

        public bool IsInput
        {
            get { return parameter.Direction == ParameterDirection.Input; }
            set { parameter.Direction = ParameterDirection.Input; }
        }

        public bool IsInputOutput
        {
            get { return parameter.Direction == ParameterDirection.InputOutput; }
            set { parameter.Direction = ParameterDirection.InputOutput; }
        }

        public bool IsReturnValue
        {
            get { return parameter.Direction == ParameterDirection.ReturnValue; }
            set { parameter.Direction = ParameterDirection.ReturnValue; }
        }

        public ParameterDirection Direction
        {
            get { return parameter.Direction; }
            set { parameter.Direction = value; }
        }

        public SPParameter()
        {
            parameter = new SqlParameter();
        }

        public SPParameter(String paramName, Object value)
        {
            paramName = CheckName(paramName);

            if (value == null)
                throw new Exception("Null value. Use DBNull.");

            parameter = new SqlParameter(paramName, value);
        }

        private String CheckName(String name)
        {
            if (String.IsNullOrEmpty(name))
                throw new Exception("Null or Empty name.");

            if (name.Substring(1).Contains('@'))
                throw new Exception("Invalid name.");

            if (!name.Contains('@'))
                name = "@" + name;

            return name;
        }

        public SPParameter Nullable()
        {
            IsNullable = true;
            return this;
        }

        public SPParameter Output()
        {
            IsOutput = true;
            return this;
        }

        public SPParameter Input()
        {
            IsInput = true;
            return this;
        }

        public SPParameter InputOutput()
        {
            IsInputOutput = true;
            return this;
        }

        public SPParameter ReturnValue()
        {
            IsReturnValue = true;
            return this;
        }

    }
}
