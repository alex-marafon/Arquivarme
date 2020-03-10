using Arquivarme.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arquivarme.Dominio.Models
{
   public class Geolocalizacao : EntitiBase
    {
        [Required]
        public string Pais { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Sigla { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public decimal CodigoIBGE { get; set; }
    }
}
