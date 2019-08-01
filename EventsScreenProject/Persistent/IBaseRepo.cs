using System.Collections.Generic;
using EventsScreenProject.Models;

namespace EventsScreenProject.Persistent
{
    public interface IBaseRepo<T> where T : class, IBaseModel
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T t);
        void Update(int id, T t);
        void Delete(int id);

    }
}
