using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }
        public int IdClienteReserva { get; set; }
        public Cliente ClienteReserva { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }
    }
}
