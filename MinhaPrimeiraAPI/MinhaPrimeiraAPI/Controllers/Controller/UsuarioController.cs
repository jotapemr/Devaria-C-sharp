using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaPrimeiraAPI.Controllers.NovaPasta
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]    //método get
        public IActionResult ObterUsuario()
        {
            var usuario = new Usuario()
            {
                Nome = "Teste",
                Email = "teste2@xxx.com",        //simulando um dado que veio de um banco de dados
                Senha = "outroteste123123"
            };
            return Ok(usuario);

            // passo a passo:
            //criei uma API
            // chamei essa API transferindo para um controlador
            // dentro do controlador criei uma rota por um método HTTP
            // criei um método para tratar essa rota
            // estenciei um usuário (simulei como se tivesse puxado do banco de dados, e devolveu esse usuário
            // e usei um framework para não voltar a senha para o usuário
            
        }
    }
}
