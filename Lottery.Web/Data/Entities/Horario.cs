namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Horario : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Descripcion")]
        [MaxLength(60)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Hora Inicia Sorteo")]
        [MaxLength(15)]
        public string HorarioInicio { get; set; }

        [Display(Name = "Hora Finaliza Sorteo")]
        [MaxLength(15)]
        public string HorarioFinaliza { get; set; }

        [Display(Name = "Is Availabe?")]
        public bool IsAvailabe { get; set; }
    }
}
