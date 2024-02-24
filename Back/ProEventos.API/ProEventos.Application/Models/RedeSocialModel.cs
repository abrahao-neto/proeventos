﻿namespace ProEventos.Application.Models
{
    public class RedeSocialModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Url { get; set; }
        public int? EventoId { get; set; }
        public int? PalestranteId { get; set; }
    }
}
