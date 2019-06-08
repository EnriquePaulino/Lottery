namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Propietario : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Nombre Propietario")]
        [MaxLength(60, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Required]
        public string Nombre { get; set; }

        public bool Status { get; set; }
    }
}
