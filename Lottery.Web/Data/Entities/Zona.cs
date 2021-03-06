﻿namespace Lottery.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Zona : IEntity
    {
        public int Id { get; set; }

        [MaxLength(60, ErrorMessage = "The field {0} only can contain {1} characters length.")]
        [Required]
        public string Descripcion { get; set; }

        public bool Status { get; set; }
    }
}
