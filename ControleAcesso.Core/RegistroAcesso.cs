namespace ControleAcesso.Core
{
    public class RegistroAcesso
    {
        public int Id { get; set; }
        public int UsuarioId{ get; set; }
        public DateTime DataHora { get; set; }
        public string TipoOperacao { get; set; }
    }
}
