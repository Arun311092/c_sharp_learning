using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace c_sharp_console_app_learn
{
    internal class _23_sqlite_pkg
    {
        static void Main(string[] args)
        {
            String createtable = @"create table if not exists students ( id INTEGER primary key, name VARCHAR(255), marks DOUBLE )";

            System.Data.SQLite.SQLiteConnection.CreateFile("student.db");

            using (System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection("data source=student.db"))
            {
                using (System.Data.SQLite.SQLiteCommand command = new System.Data.SQLite.SQLiteCommand(connection))
                {
                    connection.Open();
                    command.CommandText = createtable;
                    command.ExecuteNonQuery();

                    command.CommandText = "insert into students ( name, marks ) values ( 'a1', '87' )";
                    command.ExecuteNonQuery();

                    command.CommandText = "insert into students ( name, marks ) values ( 'b2', '88' )";
                    command.ExecuteNonQuery();

                    command.CommandText = "select * from students";
                    using (System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader["name"] + " " + reader["marks"]);
                        }
                    }

                    connection.Close();

                }
            }
        }
    }
}
