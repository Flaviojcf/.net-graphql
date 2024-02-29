using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
