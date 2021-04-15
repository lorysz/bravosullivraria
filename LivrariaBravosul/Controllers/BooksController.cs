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
    public class BooksController : Controller
    {
        private readonly ILivroApplication _application;
        public BooksController(ILivroApplication application)
        {
            _application = application;
        }

        /// <summary>
        /// Faz reserva do livro
        /// </summary>
        /// <param name="idLivro"></param>
        /// <returns></returns>
        [HttpPost("{idLivro}/reserve")]
        public IActionResult Reservar(int idLivro)
        {
            try {
                _application.ReservarLivro(idLivro);
                return Ok();
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
    }
}
