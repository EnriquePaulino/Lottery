namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Zona : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Zona")]
        [MaxLength(60)]
        [Required]
        public string Name { get; set; }

        [MaxLength(5)]
        public string Sigla { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }
    }
}
