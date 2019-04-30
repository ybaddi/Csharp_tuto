
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;

namespace Csharp_tuto.Day4.Example4
{
    class BDMAnage
    {
        MySqlConnection connection;
        string server;
        string database;
        string uid ;
        string password ;



        public BDMAnage()
        {
            init();
        }

        private void init()
        {
            server = "localhost";
            database = "csharp_formation";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" +
                "DATABASE=" + database + ";" +
                "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

       public bool OpenConnection()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connection open with success");
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Number);
                switch(ex.Number)
                {
                    case 0:
                        Console.WriteLine("server not exist, please contact your administrator");
                        break;
                    case 1042:
                        Console.WriteLine("invalid username/password , please try again");
                        break;
                    default:
                        Console.WriteLine("laho a3lam ..");
                        break;
                }
            }
            return false;
        }

       public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }   catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        //insert
        public void Insert()
        {
            string query = "INSERT INTO tableinfo (name,agr) VALUES ('youssef',12)";
            if(this.OpenConnection()==true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        // update

        public void Update()
        {
            string query = "UPDATE tableinfo SET name='baddi' , agr=23 WHERE id=1";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        // delete

        public void Delete()
        {
            string query = "DELETE FROM tableinfo where id=1";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        // select
        public  List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            if(this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query,connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] +"");
                    foreach(string str in list[0])
                        Console.WriteLine(str);
                    list[1].Add(dataReader["name"] + "");
                    Console.WriteLine("#################");
                    foreach (string str in list[1])
                        Console.WriteLine(str);
                    Console.WriteLine("#################");
                    list[2].Add(dataReader["agr"] + "");
                    foreach (string str in list[2])
                        Console.WriteLine(str);
                    Console.WriteLine("#################");

                }
                dataReader.Close();
                this.CloseConnection();
                return list;
            }
            else { return list; }

        }

        // count

        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                Count = int.Parse(cmd.ExecuteScalar() + "");

                this.CloseConnection();

                return Count;
                
            }
            else { return Count; }

        }

    }
}