using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Data
    {
        private static MySqlConnection Connection = new MySqlConnection("Server=localhost;User=root;password=;Database=Store;");
        public static List<Administrateur> GetListAdmin()
        {
            List<Administrateur> admin = new List<Administrateur>();
            string sql = "SELECT *FROM administrateur";
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Administrateur admins = new Administrateur();
                admins.adminId= (int)reader.GetInt64(0);
                admins.adminNames = reader.GetString(1);
                admins.adminAdresse = reader.GetString(2);
                admins.adminTel = reader.GetString(3);
                admins.adminMotdepasse = reader.GetString(4);;
                admin.Add(admins);
            }
            Close();
            return admin;
        }
        public static List<Utilisateur> GetListUser()
        {
            List<Utilisateur> admin = new List<Utilisateur>();
            string sql = "SELECT *FROM utilisateur";
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Utilisateur admins = new Utilisateur();
                admins.userId = (int)reader.GetInt64(0);
                admins.userNames = reader.GetString(1);
                admins.userAdresse = reader.GetString(2);
                admins.userTel = reader.GetString(3);
                admins.motdepasseutilisateur= reader.GetString(4); ;
                admin.Add(admins);
            }
            Close();
            return admin;
        }

        public static List<Client> GetListClient()
        {
            List<Client> clients = new List<Client>();
            string sql = "SELECT * FROM Client";
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Client client = new Client(
                    (int)reader.GetInt64(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    (int)reader.GetInt64(4));
                clients.Add(client);
            }
            Close();
            return clients;
        }
        public void InsertClient(Client clt)
        {
            string sql = "INSERT INTO Client VALUES(null,@name,@adresse,@tel,@sexe)";
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@name", clt.clientNames);
            cmd.Parameters.AddWithValue("@adresse", clt.clientAdresse);
            cmd.Parameters.AddWithValue("@tel", clt.clientTel);
            cmd.Parameters.AddWithValue("@sexe", clt.Sexe);

            cmd.ExecuteNonQuery();
        }
        public static void InsertAdmint(Administrateur adm)
        {
            string sql="INSERT INTO administrateur VALUES(null,@names,@adresse,@tel,@motdepasse)";
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@names", adm.adminNames);
            cmd.Parameters.AddWithValue("@adresse", adm.adminAdresse);
            cmd.Parameters.AddWithValue("@tel", adm.adminTel);
            cmd.Parameters.AddWithValue("@motdepasse", adm.adminMotdepasse);
            //cmd.Parameters.AddWithValue("@motdepasse", CryptControl.Encrypt(adm.adminmotdepassestring));
            Open();
            cmd.ExecuteNonQuery();
            Close();
        }
        public static void InsertUser(Utilisateur adm)
        {
            string sql = "INSERT INTO utilisatuer VALUES(null,@names,@adresse,@tel,@motdepasse)";
            MySqlCommand cmd = new MySqlCommand(sql, Connection);
            cmd.Parameters.AddWithValue("@names", adm.userNames);
            cmd.Parameters.AddWithValue("@adresse", adm.userAdresse);
            cmd.Parameters.AddWithValue("@tel", adm.userTel);
            cmd.Parameters.AddWithValue("@motdepasse", adm.motdepasseutilisateur);
            //cmd.Parameters.AddWithValue("@motdepasse", CryptControl.Encrypt(adm.adminmotdepassestring));
            Open();
            cmd.ExecuteNonQuery();
            Close();
        }
        static void Open()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
        static void Close()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
