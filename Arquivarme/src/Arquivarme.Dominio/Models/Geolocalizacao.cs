using Arquivarme.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arquivarme.Dominio.Models
{
   public class Geolocalizacao
    {
        public Geolocalizacao()
        {
            GeolocalizacaoId = Guid.NewGuid();
        }

        public Guid GeolocalizacaoId { get; set; }
        [Required]
        public string Pais { get; set; }
        [Required]
        public string Estado { get; set; }
        [Required]
        public string Sigla { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        [MaxLength(15)]
        public decimal CodigoIBGE { get; set; }


        public IReadOnlyCollection<CapaArquivo> CapaArquivo { get; set; }
    }
}
