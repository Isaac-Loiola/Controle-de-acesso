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

        public void RegistrarAcesso()
        {
            var cmd = Banco.Abrir();
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

        public void SaidaAcesso()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"insert into registro(id_usuario, tipo_operacao) values({UsuarioId}, 0";

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select id from registro order by id desc limit 1";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.CommandType = System.Data.CommandType.Text;
            //registros
            cmd.CommandText = "select data_hora from registro order by id desc limit 1";
            DataHora = Convert.ToDateTime(cmd.ExecuteScalar());
        }
           
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

    }
}
