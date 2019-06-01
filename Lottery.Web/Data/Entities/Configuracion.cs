namespace Lottery.Web.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class Configuracion : IEntity
    {
        public int Id { get; set; }

        public Zona Zona { get; set; }

        public int FormaCaida { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal PorcentajeCaida { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal BalanceDesactivacion { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal LimiteVentaDiaria { get; set; }

        public bool status { get; set; }

        public bool ControlTicketsGanador { get; set; }

        public bool PermitePasarBote { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal MontoDescontar { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal DescontardeCada { get; set; }

        public int TiempoCancelarTicket { get; set; }

    }
}
