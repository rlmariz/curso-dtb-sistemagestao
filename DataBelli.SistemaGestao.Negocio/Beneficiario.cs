using System;
using System.Collections.Generic;
using System.Text;

namespace DataBelli.SistemaGestao.Negocio
{
    public class Beneficiario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Plano { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
