using Proiect_PAW_Chivu_Evelyn_Andrei.Entities;
using System.Data.SQLite;

namespace Proiect_PAW_Chivu_Evelyn_Andrei
{
    internal static class DatabaseService
    {
        private static string DatabasePath => Path.Combine(AppContext.BaseDirectory, "database.db");
        private static string ConnectionString => $"Data Source={DatabasePath};Version=3";

        public static void InitializeDatabase()
        {
            using SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();

            ExecuteNonQuery(connection, "PRAGMA foreign_keys = ON");

            ExecuteNonQuery(connection,
                @"CREATE TABLE IF NOT EXISTS Pizzas (
                    Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
                    Nume TEXT NOT NULL,
                    Pret REAL NOT NULL,
                    ImagePath TEXT,
                    Cantitate INTEGER NOT NULL
                )");

            ExecuteNonQuery(connection,
                @"CREATE TABLE IF NOT EXISTS Clients (
                    Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
                    NumeClient TEXT NOT NULL,
                    AdresaLivrare TEXT
                )");
        }

        public static List<Pizza> LoadPizzas()
        {
            const string query = "SELECT Id, Nume, Pret, ImagePath, Cantitate FROM Pizzas ORDER BY Id";
            List<Pizza> pizzas = new List<Pizza>();

            using SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            using SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Pizza pizza = new Pizza(
                    Convert.ToInt32(reader["Id"]),
                    Convert.ToString(reader["Nume"]) ?? "",
                    Convert.ToDecimal(reader["Pret"]),
                    Convert.ToString(reader["ImagePath"]) ?? "",
                    Convert.ToInt32(reader["Cantitate"]));

                pizzas.Add(pizza);
            }

            return pizzas;
        }

        public static void AddPizza(Pizza pizza)
        {
            const string query =
                @"INSERT INTO Pizzas(Nume, Pret, ImagePath, Cantitate)
                  VALUES(@nume, @pret, @imagePath, @cantitate);
                  SELECT last_insert_rowid();";

            using SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@nume", pizza.nume);
            command.Parameters.AddWithValue("@pret", pizza.pret);
            command.Parameters.AddWithValue("@imagePath", pizza.imagePath);
            command.Parameters.AddWithValue("@cantitate", pizza.cantitate);

            pizza.id = Convert.ToInt32(command.ExecuteScalar());
        }

        public static void UpdatePizza(Pizza pizza)
        {
            const string query =
                @"UPDATE Pizzas
                  SET Nume = @nume,
                      Pret = @pret,
                      ImagePath = @imagePath,
                      Cantitate = @cantitate
                  WHERE Id = @id";

            using SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@nume", pizza.nume);
            command.Parameters.AddWithValue("@pret", pizza.pret);
            command.Parameters.AddWithValue("@imagePath", pizza.imagePath);
            command.Parameters.AddWithValue("@cantitate", pizza.cantitate);
            command.Parameters.AddWithValue("@id", pizza.id);

            command.ExecuteNonQuery();
        }

        public static void DeletePizza(Pizza pizza)
        {
            const string query = "DELETE FROM Pizzas WHERE Id = @id";

            using SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@id", pizza.id);

            command.ExecuteNonQuery();
        }

        public static List<Client> LoadClients()
        {
            const string query = "SELECT Id, NumeClient, AdresaLivrare FROM Clients ORDER BY Id";
            List<Client> clients = new List<Client>();

            using SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            using SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Client client = new Client(
                    Convert.ToInt32(reader["Id"]),
                    Convert.ToString(reader["NumeClient"]) ?? "",
                    Convert.ToString(reader["AdresaLivrare"]) ?? "",
                    new List<Comanda>());

                clients.Add(client);
            }

            return clients;
        }

        public static void AddClient(Client client)
        {
            const string query =
                @"INSERT INTO Clients(NumeClient, AdresaLivrare)
                  VALUES(@numeClient, @adresaLivrare);
                  SELECT last_insert_rowid();";

            using SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@numeClient", client.numeClient);
            command.Parameters.AddWithValue("@adresaLivrare", client.adresaLivrare);

            client.Id = Convert.ToInt32(command.ExecuteScalar());
        }
        //
        public static void UpdateClient(Client client)
        {
            const string query =
                @"UPDATE Clients
                  SET NumeClient = @numeClient,
                      AdresaLivrare = @adresaLivrare
                  WHERE Id = @id";

            using SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@numeClient", client.numeClient);
            command.Parameters.AddWithValue("@adresaLivrare", client.adresaLivrare);
            command.Parameters.AddWithValue("@id", client.Id);

            command.ExecuteNonQuery();
        }

        public static void DeleteClient(Client client)
        {
            const string query = "DELETE FROM Clients WHERE Id = @id";

            using SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();

            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.Parameters.AddWithValue("@id", client.Id);

            command.ExecuteNonQuery();
        }

        private static void ExecuteNonQuery(SQLiteConnection connection, string query)
        {
            using SQLiteCommand command = new SQLiteCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
}
