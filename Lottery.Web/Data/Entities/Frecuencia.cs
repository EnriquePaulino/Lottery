namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Frecuencia : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Frecuencia")]
        [MaxLength(60)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }
    }
}
