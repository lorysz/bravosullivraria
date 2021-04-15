using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaBravosul.Controllers
{
    [AllowAnonymous]
    public class ClientController : Controller
    {
        private readonly IClienteApplication _application;

        public ClientController(IClienteApplication application)
        {
            _application = application;
        }

        /// <summary>
        /// Retorna todas as reservas para o cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        [HttpGet("{idCliente}/books")]
        public IActionResult Reservas(int idCliente)
        {
            try {

                return Ok(_application.GetAllLivrosEmprestadosByIdCliente(idCliente));
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
