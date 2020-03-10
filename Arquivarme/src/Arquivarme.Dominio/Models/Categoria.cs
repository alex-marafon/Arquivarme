using Arquivarme.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arquivarme.Dominio.Models
{
    public class Categoria : EntitiBase
    {
        [Required]
        public string Categorias { get; set; }
    }
}
