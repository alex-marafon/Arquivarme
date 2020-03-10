using Arquivarme.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arquivarme.Dominio.Models
{
   public class Usuario : EntitiBase
    {
        public Usuario()
        {
            Ativo = true;
        }

        [Required]
        public decimal CPF { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Senha { get; set; }

        public bool Ativo { get; set; }
    }
}
