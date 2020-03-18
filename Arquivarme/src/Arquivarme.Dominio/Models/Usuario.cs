using Arquivarme.Dominio.Entidades;
using Arquivarme.Dominio.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arquivarme.Dominio.Models
{
   public class Usuario 
    {
        public Usuario()
        {
            UsuarioId = Guid.NewGuid();
        }

        public Guid UsuarioId { get; set; }
        [Required]
        public decimal CPF { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public Status Status { get; set; }

        


    }
}
