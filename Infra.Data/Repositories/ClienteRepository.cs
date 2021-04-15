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
    public class ClienteRepository : IClienteRepository
    {
        private readonly Context _con;

        public ClienteRepository(Context con)
        {
            _con = con;
        }

        public List<Emprestimo> GetAllLivrosEmprestadosByIdCliente(int idCliente)
        {
            return _con.Emprestimo.Include(x => x.Livro)
                .Where(x => x.IdCliente == idCliente && x.DataDevolucao == null)
                .ToList();
        }

        public Cliente GetById(int idCliente)
        {
            return _con.Cliente.Where(x => x.Id == idCliente).FirstOrDefault();
        }
    }
}
