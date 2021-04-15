using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories
{
    public interface ILivroRepository
    {
        List<Livro> GetAll();
        void ReservarLivro(Livro livro);
        Livro GetLivroById(int idLivro);
    }
}
