using Pediacai.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pediacai.Repository
{
    public interface IEmpresaRepository: IRepository
    {
        Task<Empresa[]> GetAll();

        Task<Empresa[]> GetAllPaginated(int Index, int Limit, string OrderBy);

        Task<Empresa> GetById(int Id);
    }
}
