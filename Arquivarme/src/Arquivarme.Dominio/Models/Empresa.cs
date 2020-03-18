using Arquivarme.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arquivarme.Dominio.Models
{
   public class Empresa
    {
        public Empresa() 
        { 
            EmpresaId = Guid.NewGuid();
           
        }

        public Guid EmpresaId { get; set; }
        [Required]
        [MaxLength(10)]
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
         [MaxLength(10)]
        public decimal Numero { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        [MaxLength(15)]
        public decimal TelFixo { get; set; }
        [MaxLength(15)]
        public decimal TelCelular { get; set; }
        [Required]
        public string Email { get; set; }

        public IReadOnlyCollection<CapaArquivo> CapaArquivo { get; set; }
    }
}
