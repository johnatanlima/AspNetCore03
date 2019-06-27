using System;
using System.ComponentModel.DataAnnotations;

namespace AspCore03.Models
{
    public class Escola
    {
        public Escola(){
            DataFundacao.ToShortDateString();
        }

        public int EscolaId { get; set; }
        public string Nome { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataFundacao { get; set; }
        public double CustoObra { get; set; }
    }
}

