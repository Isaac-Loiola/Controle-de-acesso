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
        public RegistroAcesso(int usuarioId, int tipoOperacao)
        {
            UsuarioId = usuarioId;
            TipoOperacao = tipoOperacao;
        }

        public void RegistrarAcesso()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into registro(id_usuario, tipo_operacao) values({UsuarioId}, {TipoOperacao})";
            cmd.ExecuteNonQuery();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select id from registro order by id desc limit 1";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.CommandType = System.Data.CommandType.Text;
            //registros
            cmd.CommandText = "select data_hora from registro order by id desc limit 1";
            DataHora = Convert.ToDateTime(cmd.ExecuteScalar());
        }

        public void SaidaAcesso()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
        }
            
    }
}
