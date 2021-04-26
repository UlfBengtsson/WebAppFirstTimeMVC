using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstTimeMVC.Models.Data;
using WebAppFirstTimeMVC.Models.ViewModel;

namespace WebAppFirstTimeMVC.Models.Repo
{
    public interface ICakeRepo
    {
        //CRUD

        Cake Create(CreateCake createCake);
        Cake Read(int id);
        List<Cake> Read();
        Cake Update(Cake cake);
        bool Delete(int id);
    }
}
