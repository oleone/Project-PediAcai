using Pediacai.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pediacai.Repository
{
    public interface IUsuarioRepository: IRepository
    {
        Task<Usuario[]> GetAll();

        Task<Usuario[]> GetAllPaginated(int Index, int Limit, string[] Filter, string OrderBy);

        Task<Usuario> GetByEmail(string Email);

        Task<Usuario> GetByUsername(string Username);
    }
}
