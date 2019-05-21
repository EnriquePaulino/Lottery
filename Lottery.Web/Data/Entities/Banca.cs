namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Banca : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Name Bank")]
        [MaxLength(60, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Name Owner")]
        public Owner Owner { get; set; }

        [Display(Name = "Indicate Locality")]
        public Location Location { get; set; }

        public bool Status { get; set; }

        public User User { get; set; }
    }
}
