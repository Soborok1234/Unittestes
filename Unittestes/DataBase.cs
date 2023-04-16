using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Unittestes
{
    public class DataBase : IDisposable
    {
        private string _dataSource = @"Host=localhost;Port=5432;Username=postgres;Password=1111;Database=Taxi;";
        private NpgsqlConnection _connection;
        public bool IsConnected { get; private set; }

        public DataBase()
        {
            _connection = new NpgsqlConnection(_dataSource);
            OpenConnection();
        }

        private void OpenConnection()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
                IsConnected = true;
            }
        }
        private void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
                IsConnected = false;
            }
        }

        public DataTable ExecuteSql(string sql)
        {
            DataTable dt = new DataTable();
            NpgsqlCommand command = new NpgsqlCommand(sql, _connection);
            var reader = command.ExecuteReader();
            dt.Load(reader);
            return dt;
        }

        public void Dispose()
        {
            CloseConnection();
        }
    }
}
