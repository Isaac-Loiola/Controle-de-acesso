using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Core
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new();
            //string strconn = @"server=192.168.18.157;database=controleacessodb;user=isaac;password=Az.103098";
            string strconn = @"server=127.0.0.1;database=controleacessodb;user=root;password=";

            MySqlConnection cn = new(strconn);
            try
            {
                cn.Open();
                cmd.Connection = cn;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return cmd;
        }
    }
}
