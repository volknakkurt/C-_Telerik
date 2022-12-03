
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakipp
{
    public static class Helper
    {
        public static List<T> DataTableToList<T>(this DataTable table) where T : class, new()
        {
            if (table == null)
            {
                return null;
            }


            var columnNames = table.Columns.Cast<DataColumn>()
        .Select(c => c.ColumnName)
        .ToList();
            var properties = typeof(T).GetProperties();
            return table.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name))
                    {
                        if (row[pro.Name] != DBNull.Value)
                        {
                            if (pro.PropertyType == typeof(string))
                            {
                                pro.SetValue(objT, Convert.ChangeType((row[pro.Name] as string).Trim(), (Nullable.GetUnderlyingType(pro.PropertyType) ?? pro.PropertyType)), null);
                            }
                            else
                            {
                                pro.SetValue(objT, Convert.ChangeType(row[pro.Name], (Nullable.GetUnderlyingType(pro.PropertyType) ?? pro.PropertyType)), null);
                            }
                        }
                    }
                }
                return objT;
            }).ToList();

            try
            {
                List<T> list = new List<T>();

                foreach (var row in table.AsEnumerable())
                {
                    T obj = new T();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            System.Reflection.PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], (Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType)), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    list.Add(obj);
                }

                return list;
            }
            catch
            {
                return null;
            }
        }

        public static T Clone<T>(this T source)
        {
            // Don't serialize a null object, simply return the default for that object
            if (Object.ReferenceEquals(source, null))
            {
                return default(T);
            }

            var deserializeSettings = new Newtonsoft.Json.JsonSerializerSettings { ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace };
            var serializeSettings = new Newtonsoft.Json.JsonSerializerSettings { ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore };
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(Newtonsoft.Json.JsonConvert.SerializeObject(source, serializeSettings), deserializeSettings);
        }

    }
}
