using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Event_Connect
{
    public class DataBase
    {
        public Boolean connectionExist { get; set; }
        public MySqlConnection conng { get; set; }
        public String conStringg { get; set; }
        public DataBase()
        {
            try
            {
                String encrypted = Encrypt.EncryptString("SERVER=localhost;DATABASE=db_eventconnect;UID=root;PASSWORD=;", "ipshufiefis598497qsdqsg4184fgdg");
                String decrypted = Encrypt.DecryptString(encrypted, "ipshufiefis598497qsdqsg4184fgdg");
                String conString = decrypted;
                MySqlConnection conn = new MySqlConnection(conString);
                conng = conn;
                conStringg = conString;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Open()
        {
            try
            {
                conng.Open();
                connectionExist = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void Close()
        {
            try
            {
                conng.Close();
                connectionExist = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
