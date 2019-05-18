namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Gasto : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Gastos")]
        [MaxLength(60)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }
    }
}
