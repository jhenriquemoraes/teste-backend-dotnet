using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OficinaApi.Models;
using OficinaApi.Services;

namespace OficinaApi.Controllers
{
    [ApiController]
     [Route("api/[controller]")]
    public class OrcamentosController : ControllerBase
    {   

        private readonly OrcamentoService _service;

        public OrcamentosController()
        {
            _service = new OrcamentoService();
        }

        [HttpPost]
        public IActionResult Criar([FromBody] CriarOrcamentoRequest request)
        {
            var resultado = _service.Criar(request);

            if (!resultado.Sucesso)
                return BadRequest(resultado.Mensagem);

            return Ok(resultado.Data);
        }
    }        
}
