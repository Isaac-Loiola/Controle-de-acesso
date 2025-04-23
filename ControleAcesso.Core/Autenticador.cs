using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Core
{
    public class Autenticador 
    {
        public int IdUsuario { get; set; }

        public Autenticador()
        {

        }

        public  bool ValidarLogin(string cpf, string senha)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select id from usuarios where cpf = '{cpf}' and senha = '{senha}'";
            //cmd.CommandText = $"select id from usuarios where cpf = '{Cpf}' and senha = md5('{Senha}')";
            return Convert.ToBoolean(IdUsuario = Convert.ToInt32(cmd.ExecuteScalar()));
   
        }
    }
}
