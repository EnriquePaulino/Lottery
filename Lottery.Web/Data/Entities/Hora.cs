namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Hora : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Indique Zona")]
        [MaxLength(60, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Required]
        public string Descripcion { get; set; }

        public bool status { get; set; }
    }
}
