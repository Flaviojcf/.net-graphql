using Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace graphqlAPI.Models
{
    public class SuperPoder
    {
        [Key]
        public Guid Id { get; set; }
        public string? Super_Poder { get; set; }
        public string? Descricao { get; set; }

        [ForeignKey("SuperHeroiId")]
        public Guid SuperHeroiId { get; set; }
        public SuperHeroi? SuperHeroi { get; set; }
    }
}
