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
        public DateTime DataCriacao { get; set; }

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
        // Construtor para cadastrar usuario
        public Usuario(string nome, string cpf, int tipoUsuario, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            TipoUsuario = tipoUsuario;
            Senha = senha;
        }


        // construtor para verificar login
        public Usuario(string cpf, string senha)
        {
            Cpf = cpf;
            Senha = senha;
        }
        public Usuario(string nome, int tipoUsuario, DateTime datacriacao)
        {
            Nome = nome;
            TipoUsuario = tipoUsuario;
            DataCriacao = datacriacao;
        }

        /// <summary>
        /// Método para inserir o usuario no banco de dados.
        /// São necessarios Nome, Cpf, TipoUsuario e Senha.
        /// </summary>
        public void Cadastrar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into usuarios(nome, cpf, tipousuario, senha) " +
                              $"values ('{Nome}', '{Cpf}', {TipoUsuario}, md5('{Senha}'))";
            cmd.ExecuteNonQuery();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id from usuarios order by id desc limit 1";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }

        /// <summary>
        /// Método estático que busca os usuarios cadastrados na aplicação.
        /// </summary>
        /// <returns>Retorna Lista de Usuarios.</returns>
        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from usuarios";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuarios.Add
                    (
                        new
                        (
                            dr.GetString(1),
                            dr.GetInt32(3),
                            dr.GetDateTime(5)
                        )
                    );
            }

            return usuarios;
        }

    }
}
