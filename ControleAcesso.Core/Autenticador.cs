﻿using System;
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

        /// <summary>
        /// Método boolean que verifica se o usuario existe no banco de dados. 
        /// </summary>
        /// <param name="cpf"></param>
        /// <param name="senha"></param>
        /// <returns>Retorna um tipo Boolean.</returns>
        public bool ValidarLogin(string cpf, string senha)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = $"select id from usuarios where cpf = '{cpf}' and senha = '{senha}'";
            cmd.CommandText = $"select id from usuarios where cpf = '{cpf}' and senha = md5('{senha}')";

            return Convert.ToBoolean(IdUsuario = Convert.ToInt32(cmd.ExecuteScalar()));
   
        }
    }
}
