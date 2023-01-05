using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraBrasilApi.DTO
{
    public class BancoResponse
    {
        public string? Ispb { get; set; }
        public string? Nome { get; set; }
        public int? Codigo { get; set; }
        public string? NomeCompleto { get; set; }
    }
}
