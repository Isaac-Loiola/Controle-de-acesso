using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleAcesso.Core
{
   public class Usuario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int TipoUsuario { get; set; }
        public string Senha { get; set; }

        public Usuario()
        {

        }
        public Usuario(int id, string nome, string cpf, int tipoUsuario, string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
            Senha = senha;
        }
        public Usuario(string nome, string cpf, int tipoUsuario, string senha)
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
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into usuarios(nome, cpf, tipousuario, senha) " +
                              $"values ('{Nome}', '{Cpf}', {TipoUsuario}, md5('{Senha}'))";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select id from usuarios order by id desc limit 1";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

    }
}
