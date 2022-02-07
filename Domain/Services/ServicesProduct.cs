using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;

namespace Domain.Services
{
    public class ServicesProduct : iServiceProduct
    {

        private readonly IProduct _iProduct;

        public ServicesProduct(IProduct iProduct)
        {
            _iProduct = iProduct;
        }
        public async Task AddProduct(Produto produto)
        {
            var validaNome = produto.ValidaPropriedadeString(produto.Nome, "Nome");
            
            var validaValor = produto.ValidaPropriedadeDecimal(produto.Valor, "Valor");

            if (validaNome && validaValor)
            {
                produto.Estado = true;
                await _iProduct.Add(produto);
            }

        }

        public async Task UpdateProduct(Produto produto)
        {
            var validaNome = produto.ValidaPropriedadeString(produto.Nome, "Nome");

            var validaValor = produto.ValidaPropriedadeDecimal(produto.Valor, "Valor");

            if (validaNome && validaValor)
            {
                produto.Estado = true;
                await _iProduct.Update(produto);
            }
        }
    }
}
