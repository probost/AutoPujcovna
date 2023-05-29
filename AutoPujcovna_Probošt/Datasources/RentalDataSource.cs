using AutoPujcovna_Probošt.Database;
using AutoPujcovna_Probošt.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPujcovna_Probošt.Datasources
{
    public class RentalDataSource : IListSource
    {
        public bool ContainsListCollection { get; set; }
        private BindingList<Rental> Rentals { get; set; }
        private DatabaseContext Context { get; set; }

        public RentalDataSource()
        {
            ContainsListCollection = true;
            Context = new DatabaseContext();
            Rentals = new BindingList<Rental>();
        }
        public void LoadAllByCar(Car car)
        {
            List<Rental> rentals = Context.Rentals.Where(r=>r.CarID == car.ID).ToList(); 

            foreach (Rental rental in rentals)
            {
                Rentals.Add(rental);
            }
        }
        IList IListSource.GetList()
        {
            return Rentals;
        }
        public void Add(Rental rental)
        {
            Context.Add(rental);
            Context.SaveChanges(); //TODO: Cannot add or update a child row: a foreign key constraint fails  
            Rentals.Add(rental);
        }
        public Rental GetByIndex(int index)
        {
            return Rentals[index];
        }
        public void Update(int index, Rental rental)
        {
            Context.Update(rental);
            Context.SaveChanges();
            Rentals[index] = rental;
        }
        public void Remove(int index)
        {
            Context.Remove(Rentals[index]);
            Context.SaveChanges();
            Rentals.RemoveAt(index);
        }
    }

}
