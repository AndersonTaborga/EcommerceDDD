using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.InterfaceServices
{
    public interface iServiceProduct
    {
        Task AddProduct(Produto product);

        Task UpdateProduct(Produto product);
    }
}
