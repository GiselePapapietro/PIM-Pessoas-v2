using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PIM_Pessoas_v2.Models
{
    public class Pessoa
    {
        
        public int Id { get; set; }

        public string Nome { get; set; }

        public long Cpf { get; set; }

        public string Logradouro { get; set; }

        public int NumeroR { get; set; }

        public int Cep { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public int Telefone { get; set; }

        public int Ddd { get; set; }

        public string Tipo { get; set; }
    }
}
