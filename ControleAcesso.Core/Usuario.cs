using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Core
{
    class Usuario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string TipoUsuario { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {

        }
        public Usuario(int id, string nome, string cpf, string tipoUsuario, string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
            Senha = senha;
        }
        public Usuario(string nome, string cpf, string tipoUsuario, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
            Senha = senha;
        }

        /// <summary>
        /// Método para inserir o usuario no banco de dados.
        /// São necessarios as seguintes propriedades: Nome, Cpf, TipoUsuario e Senha
        /// </summary>
        public void Cadastrar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into usuarios(nome, cpf, tipousuario, senha) " +
                              $"values ('{Nome}', '{Cpf}', {TipoUsuario}, '{Senha}')";
            cmd.ExecuteReader();
            cmd.CommandText = "select last_insert_id()";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

    }
}
