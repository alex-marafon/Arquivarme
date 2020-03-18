using Arquivarme.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arquivarme.Dominio.Models
{
   public class TipoMovimento
    {
        public TipoMovimento()
        {
            TipoMovimentoId = Guid.NewGuid();
        }

        public Guid TipoMovimentoId { get; set; }

        [Required]
        public string Moviento { get; set; }
        public IReadOnlyCollection<CapaArquivo> CapaArquivo { get; set; }
    }

}
