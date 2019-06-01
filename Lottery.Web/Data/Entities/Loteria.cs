namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Loteria : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Loterias")]
        [MaxLength(60)]
        [Required]
        public string Descripcion { get; set; }

        [Display(Name = "Horario")]
        [MaxLength(15)]
        public string Horario { get; set; }

        [MaxLength(5)]
        public string Sigla { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool status { get; set; }
    }
}
