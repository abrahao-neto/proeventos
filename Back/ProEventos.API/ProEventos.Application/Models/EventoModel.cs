namespace ProEventos.Application.Models
{
    public class EventoModel
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime? DataEvento { get; set; }
        public string Tema { get; set; }
        public int QtdPessoas { get; set; }
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public IEnumerable<LoteModel> Lotes { get; set; }
        public IEnumerable<RedeSocialModel> RedesSociais { get; set; }
        public IEnumerable<PalestranteEventoModel> PalestrantesEventos { get; set; }
    }
}
