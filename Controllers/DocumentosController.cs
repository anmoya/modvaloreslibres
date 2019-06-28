using System.Threading.Tasks;
using wssModValoresLibres.Data;
using wssModValoresLibres.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;

namespace wssModValoresLibres.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentosController : ControllerBase
    {
        private IDocumentoRepository _repo;

        public DocumentosController(IDocumentoRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("existedoc")]
        public async Task<ActionResult> ExisteDocumento(DTOs.DocForSearch docForSearch)
        {
            if(await _repo.GetDocumento(docForSearch.Empresa, docForSearch.TipoDocumnento, docForSearch.Folio))
                return Ok(1);

            return Ok(0);
        }

        [HttpPut("modvalslibres")]
        public async Task<Task> ModificaValoresLibres(DTOs.DocForModify docForModify){
            
        }
    }
}