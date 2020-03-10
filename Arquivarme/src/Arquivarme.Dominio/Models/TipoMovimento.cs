using Arquivarme.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arquivarme.Dominio.Models
{
   public class TipoMovimento : EntitiBase
    {
        [Required]
        public string Moviento { get; set; }
    }
}
