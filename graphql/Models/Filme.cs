﻿
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Filme
    {
        [Key]
        public Guid Id { get; set; }

        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public string? Instrutor { get; set; }
        public DateTime Lancamento { get; set; }

        [ForeignKey("SuperHeroiId")]
        public Guid SuperHeroiId { get; set; }
        public SuperHeroi? SuperHeroi { get; set; }
    }
}
