namespace Lottery.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class GastoDetalle : IEntity
    {
        public int Id { get; set; }

        [Required]
        public Gasto Gasto { get; set; }

        public Frecuencia Frecuencia { get; set; }

        [Required]
        public Dia Dia { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Monto { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }
    }
}
