using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.Common;

namespace eAgenda.Controladores.Shared
{
    public delegate T ConverterDelegate<T>(IDataReader reader);

    public static class Db
    {
        private static readonly string banco = "";
        private static readonly string connectionString = "";
        private static readonly DbProviderFactory factory;

        static Db()
        {
            banco = ConfigurationManager.AppSettings["bancoparausar"].ToLower().Trim();
            connectionString = ConfigurationManager.ConnectionStrings[banco].ConnectionString;
            string providerName = ConfigurationManager.ConnectionStrings[banco].ProviderName;
            factory = DbProviderFactories.GetFactory(providerName);
  

        }

        public static int Insert(string sql, Dictionary<string, object> parameters)
        {
            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            DbCommand command = factory.CreateCommand();
            command.CommandText = sql.AppendSelectLastInsertRowId();
            command.Connection = connection;
            command.SetParameters(parameters);
            connection.Open();
            int id = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return id;

        }

        public static void Update(string sql, Dictionary<string, object> parameters = null)
        {

            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            DbCommand command = factory.CreateCommand();
            command.CommandText = sql;
            command.Connection = connection;
            command.SetParameters(parameters);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static void Delete(string sql, Dictionary<string, object> parameters)
        {
            Update(sql, parameters);
        }

        public static List<T> GetAll<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            DbCommand command = factory.CreateCommand();
            command.CommandText = sql.AppendSelectLastInsertRowId();
            command.Connection = connection;
            command.SetParameters(parameters);
            connection.Open();
            var list = new List<T>();

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var obj = convert(reader);
                list.Add(obj);
            }
            connection.Close();
            return list;
        }

        public static T Get<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters)
        {
            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            DbCommand command = factory.CreateCommand();
            command.CommandText = sql;
            command.Connection = connection;
            command.SetParameters(parameters);
            connection.Open();
            T t = default;
            var reader = command.ExecuteReader();
            if (!reader.HasRows)
                t = default(T);
            else
            {
                reader.Read();
                t = convert(reader);
            }
            reader.Close();
            connection.Close();
            return t;
        }

        public static bool Exists(string sql, Dictionary<string, object> parameters)
        {
            DbConnection connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            DbCommand command = factory.CreateCommand();
            command.CommandText = sql;
            command.Connection = connection;
            command.SetParameters(parameters);
            connection.Open();

            int numberRows = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return numberRows > 0;
        }


        private static void SetParameters(this DbCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return;
            foreach (var parameter in parameters)
            {
                string name = parameter.Key;
                object value = parameter.Value.IsNullOrEmpty() ? DBNull.Value : parameter.Value;
                DbParameter dbParameter = factory.CreateParameter();
                dbParameter.ParameterName = name;
                dbParameter.Value = value;
                command.Parameters.Add(dbParameter);
            }
        }

        private static string AppendSelectLastInsertRowId(this string sql)
        {
            if (banco == "sqlite")
                return sql + ";SELECT last_insert_rowid()";
            else
                return sql + ";SELECT SCOPE_IDENTITY()";
        }

        public static bool IsNullOrEmpty(this object value)
        {
            return (value is string @string && string.IsNullOrEmpty(@string)) ||
                    value == null;
        }

    }
}
