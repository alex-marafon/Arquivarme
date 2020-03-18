using Arquivarme.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Arquivarme.Dominio.Models
{
   public class CapaArquivo : EntitiBase
    {

        public CapaArquivo()
        {
            DataCriacao = DataCriacao.Date;
            

            //CriadoPor recebe o Guid do Usuario 
        }

        [Required]
        [Display(Name = "Empresa")]
        public Guid EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        
        [Required]
        [Display(Name = "Localização")]
        public Guid GeolocalizacaoId { get; set; }
        public Geolocalizacao Geolocalizacao { get; set; }

        [Required]
        [Display(Name ="Tipo de Movimento")]
        public Guid TipoMovimentoId { get; set; }
        public TipoMovimento TipoMovimento { get; set; }

        [Required]
        [Display(Name = "Categoria")]
        public Guid CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        [Required]
        [Display(Name ="Data Inicial")]
        //[DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }

        [Required]
        [Display(Name = "Data Final")]
        //[DataType(DataType.Date)]
        public DateTime DataFinal { get; set; }

        public DateTime DataCriacao { get; set; }


        //Verificar uma forma para setar automatico o usuario atual.
        //public Guid UsuarioId { get; set; }
        //public Usuario Usuario { get; set; }

    }
}
