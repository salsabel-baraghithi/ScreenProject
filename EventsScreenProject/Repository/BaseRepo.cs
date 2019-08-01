using System;
using System.Collections.Generic;
using System.Linq;
using EventsScreenProject.Models;
using EventsScreenProject.Persistent;

namespace EventsScreenProject.Repository
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class, IBaseModel
    {
        public readonly Models.MyAppContext _appContext;

        public BaseRepo(Models.MyAppContext appContext)
        {
            _appContext = appContext;
        }

        public List<T> GetAll()
        {
            return _appContext.Set<T>().ToList();
        }

        public T Get(int id)
        {
            /*
             Car car = cars.Where(c => c.id == id).FirstOrDefault();
            return car;
             */
            T t = _appContext.Set<T>().Where(x => x.Id == id).FirstOrDefault();
            // Car car2 = _appContext.cars.Single(id);  //on error throw exeption
            return t;
        }

        public void Add(T t)
        {
            /* 
             if ((car.name == null) || (car.name == ""))
                 throw new Exception("name cannt be null");

             if (cars.Find(c => c.name == car.name) != null)
                 throw new Exception("name must be uniqe");

             cars.Add(car);
            */
            _appContext.Set<T>().Add(t);
            _appContext.SaveChanges();
        }

        public void Update(int id, T t)
        {

            /*
              if (Get(id) == null)
                throw new Exception("id cannt be null");

            if (newCar.id != id)
                throw new Exception("wrong id");

            if ((newCar.name == null) || (newCar.name == ""))
                throw new Exception("name cannt be null");

            if(cars.Find(c => (c.id != id) && (c.name == newCar.name) ) != null)
                 throw new Exception("name must be uniqe");
           

            // save new car
            Car car = cars.Where(c => c.id == id).FirstOrDefault();
            var index = cars.IndexOf(car);

            if (index != -1)
                cars[index] = newCar;
             */
            if (Get(id) == null)
                throw new Exception("Get(id) cannot be null");

            t.Id = id;
            _appContext.Set<T>().Update(t);
            _appContext.SaveChanges();

        }

        public void Delete(int id)
        {

            /*
             if (Get(id) != null)
            {
                Car c = Get(id);
                cars.Remove(c);
            }
             */
            _appContext.Set<T>().Remove(Get(id));
            _appContext.SaveChanges();

        }
    }
}
