using System.Threading.Tasks;
using wssModValoresLibres.Models;
using wssModValoresLibres.DTOs;

namespace wssModValoresLibres.Data
{
    public interface IDocumentoRepository
    {
         Task<bool> GetDocumento(int empr, int tipo, int folio);
    }
}