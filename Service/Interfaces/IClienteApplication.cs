﻿using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClienteApplication
    {
        List<LivroEmprestadoDTO> GetAllLivrosEmprestadosByIdCliente(int idCliente);
    }
}
