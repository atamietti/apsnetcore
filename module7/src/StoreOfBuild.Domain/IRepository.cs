namespace StoreOfBuild.Domain
{
    public interface IRepository<T>
    {
        T GetById(int id);
        void Save(T entity);

    } 
}