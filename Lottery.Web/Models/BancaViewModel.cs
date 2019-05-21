namespace Lottery.Web.Models
{
    using Lottery.Web.Data.Entities;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class BancaViewModel : Banca
    {
        //[Display(Name = "Name Owner")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a owner.")]
        public int OwnerId { get; set; }

        public IEnumerable<SelectListItem> Owner { get; set; }


        //[Display(Name = "Indicate Location")]
        [Range(1, int.MaxValue, ErrorMessage = "You must select a location.")]
        public int LocationId { get; set; }

        public IEnumerable<SelectListItem> Location { get; set; }
    }
}
