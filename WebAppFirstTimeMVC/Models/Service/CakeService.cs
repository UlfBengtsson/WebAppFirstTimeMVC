using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstTimeMVC.Models.Data;
using WebAppFirstTimeMVC.Models.Repo;
using WebAppFirstTimeMVC.Models.ViewModel;

namespace WebAppFirstTimeMVC.Models.Service
{
    public class CakeService : ICakeService
    {

        ICakeRepo _cakeRepo = new InMemoryCakeRepo();

        public Cake Create(CreateCake createCake)
        {
            return _cakeRepo.Create(createCake);
        }

        public List<Cake> FindAll()
        {
            return _cakeRepo.Read();
        }

        public List<Cake> FindByAmount(int min)
        {
            return _cakeRepo.Read()                     //Get all Cakes
                            .Where(c => c.Amount >= min)//filler amount by min
                            .ToList();                  //make it into a list
        }

        public Cake FindbyId(int id)
        {
            return _cakeRepo.Read(id);
        }

        public Cake Edit(int id, CreateCake createCake)
        {
            Cake cake = FindbyId(id);

            if (cake == null)
            {
                return null;
            }

            cake.Id = id;
            cake.Name = createCake.Name;
            cake.Detailes = createCake.Detailes;
            cake.Amount = createCake.Amount;

            return _cakeRepo.Update(cake);
        }

        public bool Remove(int id)
        {
            return _cakeRepo.Delete(id);
        }
    }
}
