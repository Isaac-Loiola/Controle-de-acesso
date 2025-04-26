using System.Runtime.CompilerServices;

namespace ControleAcesso.Core
{
    public class RegistroAcesso
    {

        public int Id { get; set; }
        public int UsuarioId{ get; set; }
        public DateTime DataHora { get; set; }
        public int TipoOperacao { get; set; }

        // Construtor necessário para o método RegistrarAcesso()
        public RegistroAcesso(int usuarioId)
        {
            UsuarioId = usuarioId;
        }

        public RegistroAcesso(int usuarioId, DateTime dataHora, int tipoOperacao)
        {

            UsuarioId = usuarioId;
            DataHora = dataHora;
            TipoOperacao = tipoOperacao;
        }
        public RegistroAcesso()
        {

        }

        /// <summary>
        /// O método registra acesso de entrada no banco de dados. 
        /// Precisa de um objeto com Id do Usuario.
        /// </summary>
        public void RegistrarAcesso()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into registro(id_usuario, tipo_operacao) values({UsuarioId}, 1)";
            cmd.ExecuteNonQuery();

            // Um  novo registro para quando o usuario sair fazer um update e não interferir no registro anterior de entrada!
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into registro(id_usuario, tipo_operacao) values({UsuarioId}, 1)";
            cmd.ExecuteNonQuery();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select id from registro order by id desc limit 1";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.CommandType = System.Data.CommandType.Text;
            //registros
            cmd.CommandText = "select data_hora from registro order by id desc limit 1";
            DataHora = Convert.ToDateTime(cmd.ExecuteScalar());
        }

        /// <summary>
        /// Método registra saida do ultimo usuario que acessou a aplicação.
        /// </summary>
        public static void SaidaAcesso()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            //cmd.CommandText = $"update registro set tipo_operacao = 0 and data_hora = current_timestamp where id order by id desc limit 1";
            cmd.CommandText = $"update registro set tipo_operacao = 0 and data_hora = current_timestamp() where id order by id desc limit 1";
            cmd.ExecuteNonQuery();

        }
           
        /// <summary>
        /// Método estático que faz uma busca completa de todos os registros de entrada e saída.
        /// </summary>
        /// <returns>Retorna uma lista geral de todos os registros.</returns>
        public static List<RegistroAcesso> ListarRegistros()
        {
            var cmd = Banco.Abrir();
            List<RegistroAcesso> registros = new();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from registro";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                registros.Add
                    (
                        new
                        (
                            dr.GetInt32(1),
                            dr.GetDateTime(2),
                            dr.GetInt32(3)
                        )
                    );
            }

            return registros;
        }

        
        public static List<RegistroAcesso> ListarRegistroPorNomeDeUsuario(string nome)
        {
            var cmd = Banco.Abrir();
            List<RegistroAcesso> registroPorNome = new();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"select id_usuario, data_hora, tipo_operacao from  registro r join usuarios u on r.id_usuario = u.id where nome = '{nome}'";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                registroPorNome.Add
                    (
                        new
                        (
                            dr.GetInt32(1),
                            dr.GetDateTime(2),
                            dr.GetInt32(3)
                        )
                    );
            }

        }
    }
}
