namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Banca : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Nombre Banca")]
        [MaxLength(60, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Required]
        public string Descripcion { get; set; }

        [Display(Name = "Nombre Dueño")]
        public Propietario Propietario { get; set; }

        [Display(Name = "Indique Localidad")]
        public Localidad Localidad { get; set; }

        [Display(Name = "Indique la Zona")]
        public Zona Zona { get; set; }

        public bool Status { get; set; }

        public User User { get; set; }
    }
}
