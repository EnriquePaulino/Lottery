namespace Lottery.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class PaisViewModel
    {
        public int PaisId { get; set; }

        public int CiudadId { get; set; }

        [Required]
        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string Descripcion { get; set; }
    }

}
