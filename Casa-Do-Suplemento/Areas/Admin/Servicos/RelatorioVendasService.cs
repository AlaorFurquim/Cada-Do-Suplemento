using Casa_Do_Suplemento.Context;
using Casa_Do_Suplemento.Models;
using Microsoft.EntityFrameworkCore;

namespace Casa_Do_Suplemento.Areas.Admin.Servicos
{
    public class RelatorioVendasService
    {
        private readonly AppDbContext context;

        public RelatorioVendasService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Pedido>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var resultado = from obj in context.Pedidos select obj;

            if (minDate.HasValue)
            {
                resultado = resultado.Where(p => p.PedidoEnviado >= minDate.Value);
            }

            if (maxDate.HasValue)
            {
                resultado = resultado.Where(p => p.PedidoEnviado <= maxDate.Value);
            }

            return await resultado
                .Include(l => l.PedidoItens)
                .ThenInclude(l => l.Suplemento)
                .OrderByDescending(l => l.PedidoEnviado)
                .ToListAsync();

        }
    }
}
