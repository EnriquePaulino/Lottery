namespace Lottery.Web.Data.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Pais : IEntity
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Pais")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        public string Descripcion { get; set; }

        public ICollection<Ciudad> Ciudades { get; set; }

        [Display(Name = "# Ciudades")]
        public int NumeroCiudad { get { return this.Ciudades == null ? 0 : this.Ciudades.Count; } }

        public bool Status { get; set; }
    }

}
