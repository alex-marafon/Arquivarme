using Arquivarme.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arquivarme.Dominio.Models
{
   public class CaixaArquivo : EntitiBase
    {
        public CaixaArquivo()
        {
            Ativo = true;
            DataCriacao = DataCriacao.Date;
        }

        [Required]
        [Display(Name = "Empresa")]
        public Guid EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataCriacao { get; set; }

    }
}
