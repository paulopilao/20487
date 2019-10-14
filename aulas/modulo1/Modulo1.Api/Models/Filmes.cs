using System;
using System.Collections.Generic;

namespace Modulo1.Api.Models
{
    public partial class Filme
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ECategoria? Categoria { get; set; }
        public int? AnoLancamento { get; set; }
    }
}
