namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Ciudad : IEntity
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string Descripcion { get; set; }

        //public ICollection<Ciudad> Ciudades { get; set; }

        //[Display(Name = "# Ciudades")]
        //public int NumeroCiudad { get { return this.Ciudades == null ? 0 : this.Ciudades.Count;}}

        public bool Status { get; set; }
    }

}
