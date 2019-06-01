namespace Lottery.Web.Models
{
    using Lottery.Web.Data.Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class BancaViewModel : Banca
    {
        internal IEnumerable<SelectListItem> _propietario;

        //[Display(Name = "Name Owner")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a propiedad.")]
        public int PropietarioId { get; set; }

        public IEnumerable<SelectListItem> Propietario { get; set; }


        [Display(Name = "Indicate Location")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a localidad.")]
        public int LocalidadId { get; set; }

        public IEnumerable<SelectListItem> Localidad { get; set; }


        [Display(Name = "Indique Zona")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a zona.")]
        public int ZonaId { get; set; }

        public new IEnumerable<SelectListItem> Zona { get; set; }
    }
}
