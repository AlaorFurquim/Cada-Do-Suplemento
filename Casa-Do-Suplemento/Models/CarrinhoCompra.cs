using Casa_Do_Suplemento.Context;

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
    }
}
