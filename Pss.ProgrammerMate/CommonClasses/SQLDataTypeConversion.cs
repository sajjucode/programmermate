using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pss.ProgrammerMate.CommonClasses
{
    /// <summary>
    /// use to Convert SQL Data Type to C# Types
    /// </summary>
    public class SQLDataTypeConversion
    {
        public static string getType(string SQl_DataType)
        {
            try
            {
                switch(SQl_DataType.ToLower())
                {
                    case "int":
                        return "int";
                    case "bigint":
                        return "Int64";
                    case "decimal":
                        return "Single";
                    case "sigle":
                        return "Single";
                    case "varchar":
                        return "string";
                    case "datetime":
                        return "DateTime";
                    case "nvarchar":
                        return "string";
                    case "text":
                        return "string";
                    case "bit":
                        return "Boolean";
                    default:
                        return SQl_DataType;

                }
            }
            catch (Exception ex)
            {
                return SQl_DataType;
            }
        }

        public static string getDataType (string DataType)
        {
            try
            {
                switch (DataType.ToLower())
                {
                    case "int":
                        return "int?";
                    case "bigint":
                        return "Int64?";
                    case "single":
                        return "Single?";
                    case "sigle":
                        return "Single?";                    
                    case "datetime":
                        return "DateTime?";                    
                    case "bit":
                        return "Boolean?";
                    default:
                        return DataType;

                }
            }
            catch (Exception ex)
            {
                return DataType;
            }
        }
    }
}
