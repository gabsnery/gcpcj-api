using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJGCPSJ.Repositorio
{
    public interface IRepositorio <T> where T: class
    {
        IEnumerable<T> SelectAll();
       // T SelectById(int id, string lazyloading);
        void Update(T entidade);
        void Add(T entidade);
        void Delete(int id);
        int SelectCount();
    }
}
