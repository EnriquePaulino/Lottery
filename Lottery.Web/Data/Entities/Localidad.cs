namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Localidad : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Localidad")]
        [MaxLength(60)]
        [Required]
        public string Name { get; set; }

        public int Zona { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }
    }
}
