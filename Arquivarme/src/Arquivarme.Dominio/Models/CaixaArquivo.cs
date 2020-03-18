using Arquivarme.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arquivarme.Dominio.Models
{
   public class CaixaArquivo
    {
        public CaixaArquivo()
        {
            CaixaArquivoId = Guid.NewGuid();
            Entrege = false;
            DataCriacao = DataCriacao.Date;
        }


        [Required]
        public Guid CaixaArquivoId { get; set; }

        public bool Entrege { get; set; }

        public DateTime DataCriacao { get; set; }

        [Required]
        [Display(Name = "Empresa")]
        public Guid EmpresaId { get; set; }
        public Empresa Empresa { get; set; }

    }
}
