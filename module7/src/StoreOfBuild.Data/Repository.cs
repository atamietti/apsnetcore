using StoreOfBuild.Domain;
using System.Linq;
namespace StoreOfBuild.Data
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly ApplicationDbContext _context;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public T GetById(int id)
        {
          return   _context.Set<T>().SingleOrDefault( t=> t.Id == id);
        }

        public void Save(T entity)
        {
            if(entity.Id == 0)
                _context.Add(entity);
            else
                _context.Update(entity);
         
            _context.SaveChanges();
        }
    }
}