using java.util;
using javax.xml.crypto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsTakipp.Services;
using IsTakipp.DTO;

namespace IsTakipp.Services
{
    public class Baglanti
    {
        static SqlConnection localCnx = null;

        static string _getConnectionString;

        public static string GetConnectionString()
        {

            _getConnectionString = "Data Source=HP\\SQLEXPRESS;Initial Catalog=Kullanici_Yetkilendirme;Integrated Security=True";

            return _getConnectionString;
        }

        public static SqlConnection GetDbCon()
        {
            if (localCnx == null)
            {
                localCnx = new SqlConnection(GetConnectionString());
                try
                {
                    localCnx.Open();
                }
                catch (Exception ex)
                {

                    throw new Exception("Bağlantı Hatası: " + ex.Message + (ex.InnerException != null ? ("\r\n" + ex.InnerException.Message) : string.Empty));
                }
            }

            if (localCnx.State == ConnectionState.Closed)
            {
                localCnx.Open();
            }

            return localCnx;
        }
        private static DataResultDTO selectQuery(string qu, SqlParameter[] parameters = null, SqlConnection connection = null, SqlTransaction transaction = null)
        {
            DataResultDTO result = new DataResultDTO();
            try
            {

                SqlParameter[] parametreler = SetParameters(ref qu, parameters);
                using (SqlDataAdapter adapter = new SqlDataAdapter(qu, connection))
                {
                    if (transaction != null)
                    {
                        adapter.SelectCommand.Transaction = transaction;
                    }
                    adapter.SelectCommand.Parameters.Clear();
                    if (parametreler != null)
                    {
                        adapter.SelectCommand.Parameters.AddRange(parametreler.ToArray());
                    }

                    System.Data.DataTable dtRes = new System.Data.DataTable();
                    adapter.Fill(dtRes);
                    result.ResultData = dtRes;
                }
            }
            catch (Exception ex)
            {
                result.Hata = ex.Message + (ex.InnerException != null ? ("\r\n" + ex.InnerException.Message) : string.Empty);
            }
            return result;

        }

        public static DataResultDTO Select(string qu, SqlParameter[] parameters = null, SqlConnection con = null, SqlTransaction transaction = null)
        {
            DataResultDTO result = new DataResultDTO();
            if (con == null)
            {
                SqlConnection tempCon = GetDbCon();
                if (tempCon.State == ConnectionState.Closed)
                {
                    tempCon.Open();
                }

                try
                {
                    result = result = selectQuery(qu, parameters, tempCon, transaction);
                }
                finally
                {

                }

            }
            else
            {
                result = selectQuery(qu, parameters, con, transaction);

            }
            return result;
        }



        public static SqlParameter[] SetParameters(ref string qu, SqlParameter[] parameters)
        {
            if (parameters == null)
            {
                return null;
            }
            List<SqlParameter> tmpPrms = parameters.ToList();
            string tmp = qu;
            foreach (SqlParameter p in tmpPrms.ToList())
            {

                //tmp = tmp.Replace(p.ParameterName.ToString(), p.Value == DBNull.Value ? "NULL" : ("'" + (p.Value == null ? "" : p.Value.ToString()) + "'"));
                if (p.Value == null)
                {
                    string prmVal = p.Value == DBNull.Value ? "NULL" : ("'" + (p.Value == null ? "" : p.Value.ToString()) + "'");
                    tmp = replaceParameter(tmp, p.ParameterName + "[]", prmVal);
                    tmp = replaceParameter(tmp, p.ParameterName, prmVal);

                    qu = replaceParameter(qu, p.ParameterName + "[]", prmVal);
                    qu = replaceParameter(qu, p.ParameterName, prmVal);
                    //tmp = tmp.Replace(p.ParameterName.ToString() + "[]", p.Value == DBNull.Value ? "NULL" : ("'" + (p.Value == null ? "" : p.Value.ToString()) + "'"));
                    //tmp = tmp.Replace(p.ParameterName.ToString(), p.Value == DBNull.Value ? "NULL" : ("'" + (p.Value == null ? "" : p.Value.ToString()) + "'"));

                    //qu = qu.Replace(p.ParameterName + "[]", "''");
                    //qu = qu.Replace(p.ParameterName, "''");

                    tmpPrms.Remove(p);
                }
                else if (p.Value.GetType().IsArray && p.Value.GetType() != typeof(System.Byte[]))
                {
                    string aa = getArrayListResult(p.Value);
                    string prmVal = p.Value == DBNull.Value ? "NULL" : (p.Value == null ? "" : aa);

                    tmp = replaceParameter(tmp, p.ParameterName + "[]", prmVal);
                    tmp = replaceParameter(tmp, p.ParameterName, prmVal);

                    qu = replaceParameter(qu, p.ParameterName + "[]", prmVal);
                    qu = replaceParameter(qu, p.ParameterName, prmVal);


                    //tmp = tmp.Replace(p.ParameterName.ToString() + "[]", p.Value == DBNull.Value ? "NULL" : ((p.Value == null ? "" : aa)));

                    //qu = qu.Replace(p.ParameterName + "[]", aa);
                    tmpPrms.Remove(p);
                }
                else
                {
                    string prmVal = p.Value.GetType() == typeof(DateTime) ?
                        ("'" + (p.Value == null ? "" : ((DateTime)p.Value).ToString("yyyyMMdd HH:mm:ss")) + "'")
                        : p.Value == DBNull.Value ? "NULL" : ("'" + (p.Value == null ? "" : p.Value.ToString()) + "'");

                    tmp = replaceParameter(tmp, p.ParameterName + "[]", prmVal);
                    tmp = replaceParameter(tmp, p.ParameterName, prmVal);

                    //qu = replaceParameter(qu, p.ParameterName + "[]", prmVal);
                    //qu = replaceParameter(qu, p.ParameterName, prmVal);


                    //if (p.Value.GetType() == typeof(DateTime))
                    //{
                    //    tmp = tmp.Replace(p.ParameterName.ToString(), ("'" + (p.Value == null ? "" : ((DateTime)p.Value).ToString("yyyyMMdd HH:mm:ss")) + "'"));
                    //}
                    //else
                    //{
                    //    tmp = tmp.Replace(p.ParameterName.ToString(), p.Value == DBNull.Value ? "NULL" : ("'" + (p.Value == null ? "" : p.Value.ToString()) + "'"));
                    //}
                }
            }
            return tmpPrms.ToArray();
        }

        private static string replaceParameter(string input, string from, string to)
        {

            if (input == null)
            {
                return null;
            }
            if (from.Contains("[]"))
            {
                return input.Replace(from, to);
            }

            var searchString = from;
            var replaceWith = to;
            var pattern = @"(?:(?<=^|(\s|=|,|;|\())(?=\S|$)|(?<=^|\S)(?=\s|$))"
                          + searchString +
                          @"(?:(?<=^|(\s))(?=\S|$)|(?<=^|\S)(?=(\s|=|,|;|\))|$))";

            string result = System.Text.RegularExpressions.Regex.Replace(input, pattern, replaceWith, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            return result;

        }
        private static string getArrayListResult(object values)
        {
            string bosStr = "''";
            if (values is int[])
            {

                return ((values as int[]).Length == 0) ? bosStr : string.Join(",", (from i in (values as int[]) select i.ToString()).ToArray());
            }

            if (values is string[])
            {
                return ((values as string[]).Length == 0) ? bosStr : string.Join(",", (from i in (values as string[]) select "'" + i.ToString() + "'").ToArray());
            }

            //if (typeof(T) == typeof(string))
            //{
            //    return string.Join(",", (from i in values select "'" + i.ToString() + "'").ToArray());
            //}
            return string.Empty;
        }




        public static DataResultDTO CommandScalar(string qu, SqlParameter[] parameters = null, SqlConnection con = null, SqlTransaction transaction = null)
        {

            return commandQuery(qu, ECommandExecute.Scalar, parameters, con, transaction);
        }

        private static DataResultDTO commandQuery(string qu, ECommandExecute commandType, SqlParameter[] parameters = null, SqlConnection con = null, SqlTransaction transaction = null)
        {
            DataResultDTO result = new DataResultDTO();
            if (con == null)
            {
                SqlConnection tempCon = GetDbCon();
                if (tempCon.State == ConnectionState.Closed)
                {
                    tempCon.Open();
                }

                try
                {
                    result = command(qu, commandType, parameters, tempCon, transaction);
                }
                finally
                {
                    //tempCon.Dispose();
                }
                return result;
            }
            else
            {
                return command(qu, commandType, parameters, con, transaction);
            }
        }

        private static DataResultDTO command(string qu, ECommandExecute commandType, SqlParameter[] parameters = null, SqlConnection connection = null, SqlTransaction transaction = null)
        {
            DataResultDTO res = new DataResultDTO();

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = connection;
                    if (transaction != null)
                    {
                        cmd.Transaction = transaction;
                    }
                    SqlParameter[] parametreler = SetParameters(ref qu, parameters);

                    cmd.CommandText = qu;

                    cmd.Parameters.Clear();
                    if (parametreler != null)
                    {
                        cmd.Parameters.AddRange(parametreler.ToArray());
                    }

                    if (commandType == ECommandExecute.Scalar)
                    {
                        res.ResultObject = cmd.ExecuteScalar();
                    }
                    else if (commandType == ECommandExecute.NonQuery)
                    {
                        res.ResultObject = cmd.ExecuteNonQuery();
                    }
                    else if (commandType == ECommandExecute.Reader)
                    {
                        SqlDataReader adapter = cmd.ExecuteReader();
                        DataTable dtRes = new System.Data.DataTable();
                        dtRes.Load(adapter);
                        return res;
                    }
                    return res;
                }
                catch (Exception ex)
                {
                    res.Hata = ex.Message + (ex.InnerException != null ? ("\r\n" + ex.InnerException.Message) : string.Empty);
                    return res;
                }
            }
        }

    }
}
