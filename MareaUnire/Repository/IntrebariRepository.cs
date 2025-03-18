using MareaUnire.Model;
using MareaUnire.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MareaUnire.Repository {
    public class IntrebariRepository : IRepository<Intrebare> {
        private List<Intrebare> intrebari = new List<Intrebare>();
        private DatabaseConfig databaseConfig;
        public IntrebariRepository(DatabaseConfig _databaseConfig) {
            databaseConfig = _databaseConfig;
            LoadIntrebari();
        }
        public void LoadIntrebari() {
            string connectionString = databaseConfig.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                string query = "SELECT * FROM Intrebari";

                using (SqlCommand command = new SqlCommand(query, connection)) {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader()) {
                        while (reader.Read()) {
                            string text = (string)reader["text"];
                            string raspuns1 = (string)reader["r1"];
                            string raspuns2 = (string)reader["r2"];
                            string raspuns3 = (string)reader["r3"];
                            string raspuns4 = (string)reader["r4"];
                            string raspunsCorect = (string)reader["raspuns"];

                            Intrebare intrebare = new Intrebare(text, raspuns1, raspuns2, raspuns3, raspuns4, raspunsCorect);
                            intrebari.Add(intrebare);
                        }
                    }
                }
            }
        }

        public List<Intrebare> GetAll() {
            return intrebari;
        }
    }
}
