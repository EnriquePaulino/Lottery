namespace Lottery.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Hora : IEntity
    {
        public int Id { get; set; }

        public int Banca { get; set; }

        [Display(Name = "Dia")]
        [MaxLength(10, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Required]
        public string Dia { get; set; }

        [Required]
        [Display(Name = "Apertura")]
        public DateTime HoraApertura { get; set; }

        [Required]
        [Display(Name = "Cierre")]
        public DateTime HoraCierre { get; set; }
    }
}
