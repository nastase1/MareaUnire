using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MareaUnire.Utils {
    public class DatabaseConfig {
        // Create a singleton for the class. It will hold the connection string
        private static DatabaseConfig instance = null;

        // Create a property for the connection string
        public string ConnectionString { get; set; }

        // Create a constructor for the class
        DatabaseConfig() {
            this.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nasta\\OneDrive\\Desktop\\Csharp\\MareaUnire\\bin\\Debug\\MareaUnire.mdf;Integrated Security=True;Connect Timeout=30";
        }

        // Create a method that returns the instance of the class
        public static DatabaseConfig GetInstance() {
            if (instance == null) {
                instance = new DatabaseConfig();
            }
            return instance;
        }
    }
}
