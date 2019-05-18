namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Banca : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(60)]
        [Required]
        public string Name { get; set; }

        //public Propietario Propietario { get; set; }

        //public Localidad Localidad { get; set; }

        //public Horario Horario { get; set; }

        //public Precio Precio { get; set; }

        public Loteria Loteria { get; set; }

        //public Gasto Gasto { get; set; }

        public Zona Zona { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public double Monto { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }
    }
}
