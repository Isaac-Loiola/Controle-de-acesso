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

        public void Cadastrar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into usuarios(nome, cpf, tipousuario, senha) " +
                              $"values ('{Nome}', '{Cpf}', {TipoUsuario}, '{Senha}')";
            cmd.ExecuteReader();
        }

    }
}
