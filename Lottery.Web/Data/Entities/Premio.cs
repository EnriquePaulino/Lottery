namespace Lottery.Web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Premio : IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Nombre Loteria")]
        public int Loteria { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? Fecha { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal PrimeraDirecto { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal SegundoDirecto { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal TerceraDirecto { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal DoblesDirecto { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal PrimeraPale { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal SegundoPale { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal TerceraPale { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal DoblesPale { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal PrimeraTripleta { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal SegundoTripleta { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal SecuenciaCash3Straingt { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal DoblesCash3Straingt { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Way3_2IdenticosCash3Box { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Way6_3UnidadCash3Box { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal SecuenciaPlay4Straingt { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal DoblesPlay4Straingt { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Way4_3IdenticosPlay4Box { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Way6_2IdenticosPlay4Box { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Way12_2IdenticosPlay4Box { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Way24_4UnicosPlay4Box { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal SecuenciaPick5Straingt { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal DoublesPick5Straingt { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Way5_4IdenticosPick5Box { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Way10_3IdenticosPick5Box { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Way20_3IdenticosPick5Box { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Way30_2IdenticosPick5Box { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Way60_2IdenticosPick5Box { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Way120_5UnicosPick5Box { get; set; }

        public bool Status { get; set; }
    }
}
