using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Models
{
    public class EventoAddModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Por favor, informe o local do evento.")]
        public string Local { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data do evento.")]
        public DateTime? DataEvento { get; set; }

        [Required(ErrorMessage = "Por favor, informe o tema do evento.")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "Por favor, informe a quantidade de pessoas do evento.")]
        public int QtdPessoas { get; set; }

        [Required(ErrorMessage = "Por favor, informe uma imagem do evento.")]
        public string ImagemURL { get; set; }

        [Required(ErrorMessage = "Por favor, informe o telefone para contato do evento.")]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "Por favor, informe um email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email para contato do evento.")]
        public string Email { get; set; }

        public IEnumerable<LoteModel>? Lotes { get; set; }
        public IEnumerable<RedeSocialModel>? RedesSociais { get; set; }
        public IEnumerable<PalestranteEventoModel>? PalestrantesEventos { get; set; }
    }
}
