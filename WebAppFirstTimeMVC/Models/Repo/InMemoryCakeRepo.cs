using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstTimeMVC.Models.Data;
using WebAppFirstTimeMVC.Models.ViewModel;

namespace WebAppFirstTimeMVC.Models.Repo
{
    public class InMemoryCakeRepo : ICakeRepo
    {
        private static List<Cake> cakesList = new List<Cake>();
        private static int idCounter = 0;

        //just for easy-demo-use
        public InMemoryCakeRepo()
        {
            if (cakesList.Count == 0)
            {
                Create(new CreateCake() { Name = "Straberry Cake", Amount = 4, Detailes = "Sweet Straberrys" });
                Create(new CreateCake() { Name = "Rasseberry Cake", Amount = 6, Detailes = "Rasseberry flavored" });
                Create(new CreateCake() { Name = "Chocolate Cake", Amount = 8, Detailes = "Sweet Chocolate" });
            }

        }

        public Cake Create(CreateCake createCake)
        {
            Cake cake = new Cake()
            {
                Id = ++idCounter,
                Name = createCake.Name,
                Detailes = createCake.Detailes,
                Amount = createCake.Amount
            };

            cakesList.Add(cake);

            return cake;
        }


        public Cake Read(int id)
        {
            return cakesList.SingleOrDefault(c => c.Id == id);
        }

        public List<Cake> Read()
        {
            return cakesList;
        }

        public Cake Update(Cake cake)
        {
            Cake originalCake = Read(cake.Id);

            if (originalCake == null)
            {
                return null;
            }

            originalCake.Name = cake.Name;
            originalCake.Detailes = cake.Detailes;
            originalCake.Amount = cake.Amount;

            return originalCake;
        }

        public bool Delete(int id)
        {
            Cake originalCake = Read(id);

            if (originalCake == null)
            {
                return false;
            }

            return cakesList.Remove(originalCake);
        }
    }
}
