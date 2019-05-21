namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Owner
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(60, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Required]
        public string Name { get; set; }

        public bool status { get; set; }
    }
}
