using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Models
{
    public class PalestranteAddModel
    {
        [Required(ErrorMessage = "Por favor, informe o nome do palestrante.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe o minicurriculo do palestrante.")]
        public string MiniCurriculo { get; set; }

        [Required(ErrorMessage = "Por favor, informe uma imagem do palestrante.")]
        public string ImagemUrl { get; set; }

        [Required(ErrorMessage = "Por favor, informe o telefone de contato do palestrante.")]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "Por favor, informe um email válido.")]
        [Required(ErrorMessage = "Por favor, informe o email de contato do palestrante.")]
        public string Email { get; set; }

        public IEnumerable<RedeSocialModel> RedesSociais { get; set; }
        public IEnumerable<PalestranteEventoModel> PalestrantesEventos { get; set; }
    }
}
