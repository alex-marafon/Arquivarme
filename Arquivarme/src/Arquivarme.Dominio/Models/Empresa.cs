using Arquivarme.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arquivarme.Dominio.Models
{
   public class Empresa : EntitiBase
    {
        [Required]
        public decimal Codigo { get; set; }
        [Required]
        public string NomeFantasia { get; set; }
        [Required]
        public string InscricaoFederal { get; set; }
        [Required]
        public string InscricaoEstadual { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public decimal Numero { get; set; }
        [Required]
        public string Bairro { get; set; }

        [Required]
        public Guid GeolocalizacaoId { get; set; }
        public virtual Geolocalizacao Geolocalizacao { get; set; }

        [Required]
        public decimal TelFixo { get; set; }
        public decimal TelCelular { get; set; }
        [Required]
        public string Email { get; set; }


        [Display(Name = "Empresa")]
        public Guid EmpresaId { get; set; }
        public Empresa EmpresaRelacionadas { get; set; }


    }
}
