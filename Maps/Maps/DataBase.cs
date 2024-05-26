using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.SqlClient;
using System.Data;

namespace Maps {
     public class DataBase {
        NpgsqlConnection _conn;
        public DataBase() {   
            _conn = new NpgsqlConnection($"Server = localhost; Port=5432;Database=maps;User Id = postgres; Password=postgres1");
        }
        public void openConnection() {
            if (_conn.State != ConnectionState.Open) {
                try {
                    _conn.Open();
                }
                catch {}
            }
        }
        public void closeConnection() {
            if (_conn.State != ConnectionState.Closed) {
                _conn.Close();
            }
        }
        public NpgsqlConnection GetConnection() {
            return _conn;
        }
    }
}
