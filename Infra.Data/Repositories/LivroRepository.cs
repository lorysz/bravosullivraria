using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private readonly Context _con;

        public LivroRepository(Context con)
        {
            _con = con;
        }

        public List<Livro> GetAll()
        {
            return _con.Livro.Include(x => x.Emprestimos).ToList();
        }

        public Livro GetLivroById(int idLivro)
        {
            return _con.Livro.Where(x => x.Id == idLivro).FirstOrDefault();
        }

        public void ReservarLivro(Livro livro)
        {
            _con.Livro.Update(livro);
            _con.SaveChanges();
        }
    }
}
