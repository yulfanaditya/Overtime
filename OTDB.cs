using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace OT_Management
{
    public class OTDB
    {

            MySqlConnection connecting;
            private string server = "192.168.110.22";
            private string database = "overtime";
            private string user = "root";
            private string password = "123";

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            public MySqlConnection inializing()
            {
                string connect;

                connect = "SERVER=" + server + ";" + "DATABASE="
                + database + ";" + "UID=" + user + ";" + "PASSWORD=" + password + ";";

                return connecting = new MySqlConnection(connect);
            }

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            public bool CheckConnection()
            {
                try
                {
                    connecting.Open();

                    return true;
                }
                catch (MySqlException ex)
                {

                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server. Call at *160 or *146");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }

                    return false;
                }
         }          
    }
}
