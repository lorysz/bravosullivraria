using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ILivroApplication
    {
        List<LivroDTO> GetAll();
        void ReservarLivro(int IdLivro);
    }
}
