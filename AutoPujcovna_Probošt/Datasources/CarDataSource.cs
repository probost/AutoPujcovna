using AutoPujcovna_Probošt.Database;
using AutoPujcovna_Probošt.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPujcovna_Probošt.Datasources
{
    public class CarDataSource : IListSource
    {
        public bool ContainsListCollection { get; set; }
        private BindingList<Car> Cars { get; set; }
        private DatabaseContext Context { get; set; }

        public CarDataSource()
        {
            ContainsListCollection = true;
            Cars = new BindingList<Car>();
            Context = new DatabaseContext();
        }

        public void LoadAll()
        {
            //Car car1 = new Car("Toyota","Corolla",1990,2500);
            //Cars.Add(car1);

            List<Car> cars = Context.Cars.ToList();

            foreach (Car car in cars)
            {
                Cars.Add(car);
            }
        }

        public IList GetList()
        {
            return Cars;
        }
        public List<Car> GetAll()
        {
            return Cars.ToList();
        }
        public void Add(Car car)
        {
            Context.Add(car);
            Context.SaveChanges();
            Cars.Add(car);
        }
        public Car GetByIndex(int index)
        {
            return Cars[index];
        }
        public void Update(int index,Car car)
        {
            Context.Update(car);
            Context.SaveChanges();
            Cars[index] = car;
        }
        public void Remove(int index)
        {
            Context.Remove(Cars[index]);
            Context.SaveChanges();
            Cars.RemoveAt(index);
        }

    }
}
