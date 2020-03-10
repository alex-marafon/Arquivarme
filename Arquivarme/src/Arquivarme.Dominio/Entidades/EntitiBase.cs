using System;
using System.Collections.Generic;
using System.Text;

namespace Arquivarme.Dominio.Entidades
{
    public class EntitiBase
    {
        public EntitiBase()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}
