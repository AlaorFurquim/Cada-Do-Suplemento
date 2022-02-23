using Casa_Do_Suplemento.Context;
using Microsoft.EntityFrameworkCore;

namespace Casa_Do_Suplemento.Models
{
    public class CarrinhoCompra
    {

        private readonly AppDbContext _context;

        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }

        public String CarrinhoCompraId { get; set; }

        public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

        public static CarrinhoCompra GetCarrinho(IServiceProvider services)
        {
            //define uma sessão
            ISession session =
                services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            //ontem um serviço dp tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            //obtem ou gera o Id do carronho
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();
            
            //atribui o id do carriho na sessão
            session.SetString("CarrinhoId", carrinhoId);

            //retorno o carrinho com o contexto e o id atribuido ou obtido
            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId
            };

        }

        public void AdicionarAoCarrinho(Suplemento suplemento)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItens.
            SingleOrDefault(s => s.Suplemento.SuplementoId == suplemento.SuplementoId && s.CarrinhoCompraId == CarrinhoCompraId);

            if(carrinhoCompraItem == null)
            {
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraId = CarrinhoCompraId,
                    Suplemento = suplemento,
                    Quantidade = 1
                };
                _context.CarrinhoCompraItens.Add(carrinhoCompraItem);
            }
            else
            {
                carrinhoCompraItem.Quantidade++;
            }
            _context.SaveChanges();
        }

        public void RemoveDoCarrinho(Suplemento suplemento)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItens.
            SingleOrDefault(s => s.Suplemento.SuplementoId == suplemento.SuplementoId && s.CarrinhoCompraId == CarrinhoCompraId);

            

            if(carrinhoCompraItem != null)
            {
                if (carrinhoCompraItem.Quantidade > 1)
                {
                    carrinhoCompraItem.Quantidade--;
                    
                }
                else
                {
                    _context.CarrinhoCompraItens.Remove(carrinhoCompraItem);
                }
            }
            _context.SaveChanges();   
        }

        public List<CarrinhoCompraItem> GetCarrinhoCompraItems()
        {
            return CarrinhoCompraItems ??
                (CarrinhoCompraItems = _context.CarrinhoCompraItens.Where
                (c => CarrinhoCompraId == CarrinhoCompraId)
                .Include(s => s.Suplemento)
                .ToList());

        }

        public void LimpaCarrinho()
        {
             var CarrinhoItens = _context.CarrinhoCompraItens.Where
                (c => CarrinhoCompraId == CarrinhoCompraId);

            _context.CarrinhoCompraItens.RemoveRange(CarrinhoItens);
            _context.SaveChanges();

        }

        public decimal GetCarrinhoCompraTotal()
        {
            var total = _context.CarrinhoCompraItens.Where
                (c => CarrinhoCompraId == CarrinhoCompraId)
                .Select(c => c.Suplemento.Preco * c.Quantidade).Sum();

            return total;
        }
    }
}
