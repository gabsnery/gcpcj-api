using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using PROJGCPSJ.Repositorio;
using PROJGCPSJ.Models;

namespace PROJGCPSJ
{
    public class RepoSQL<T> : IRepositorio<T> where T : class
    {
        private readonly APIMeuContexto _contexto;
        private DbSet<T> entidades;
     
        public RepoSQL(APIMeuContexto contexto)
        {
            _contexto = contexto;
            entidades = contexto.Set<T>();
        }
        [EnableCors]
        public void Add(T entidade)
        { 
            entidades.Add(entidade);
            _contexto.SaveChanges();
        }
        [EnableCors]
        public void Delete(int id)
        {
            var objeto = entidades.Find(id);
            entidades.Remove(objeto);
            _contexto.SaveChanges();
        }
        [EnableCors]
        public IEnumerable<T> SelectAll()
        {
            return entidades.ToList();
        }
       /* [EnableCors]
        public T SelectById(string campo ,int id, string lazyloading )
        {


            return entidades.FirstOrDefault(x => x. == id);
        }*/
        [EnableCors]
        public int SelectCount()
        {
            return entidades.Count();
        }
        [EnableCors]
        public void Update(T entidade)
        {   
            entidades.Update(entidade);
            _contexto.SaveChanges();
        }
    }
}
