using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdLivro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime? DataDevolucao { get; set; }

        public Cliente Cliente { get; set; }
        public Livro Livro { get; set; }


        public string ValidarMulta(DateTime dataDevolucao)
        {
            var dataAtual = DateTime.Now;
            var comparacao = dataDevolucao.CompareTo(dataAtual);

            if (comparacao == 3) {
                return "Multa: 3%, Juros ao dia: 0.2%";
            }
            else if (comparacao > 3 && comparacao <= 5) {
                return "Multa: 5%, Juros ao dia: 0.4%";
            }
            else if (comparacao > 5) {
                return "Multa: 7%, Juros ao dia: 0.6%";
            }
            else {
                return "Multa: 0%, Juros ao dia: 0%";
            }
        }
    }
}
