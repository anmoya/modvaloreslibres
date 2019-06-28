using System.Threading.Tasks;
using wssModValoresLibres.DTOs;
using wssModValoresLibres.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace wssModValoresLibres.Data
{
    public class DocumentoRepository : IDocumentoRepository
    {
        private readonly Esuite52Context _context;
        public DocumentoRepository(Esuite52Context context)
        {
            _context = context;

        }

        public async Task<bool> GetDocumento(int empr, int tipo, int folio)
        {
            if (await _context.DteEncaDocu.AnyAsync(
                x =>    x.CodiEmpr == empr && 
                        x.TipoDocu == tipo && 
                        x.FoliDocu == folio))
                return true;

            return false;
        }

        public async Task<bool> UpdValsLibresDocumento(int empr, int tipo, int folio, Dictionary<string, string> vals)
        {
            var existe = await GetDocumento(empr, tipo, folio);
            
            if (!existe)
                return false;

            var docu = await _context.DteEncaDocu.FirstAsync<DteEncaDocu>(
                x   =>  x.CodiEmpr == empr && 
                        x.TipoDocu == tipo && 
                        x.FoliDocu == folio);
        
            
            

            return false;
        }
    }
}