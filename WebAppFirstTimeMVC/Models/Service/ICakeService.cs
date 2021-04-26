using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstTimeMVC.Models.Data;
using WebAppFirstTimeMVC.Models.ViewModel;

namespace WebAppFirstTimeMVC.Models.Service
{
    public interface ICakeService
    {
        //C
        Cake Create(CreateCake createCake);
        //R
        Cake FindbyId(int id);
        List<Cake> FindByAmount(int min);
        List<Cake> FindAll();
        //U
        Cake Edit(int id, CreateCake createCake);
        //D
        bool Remove(int id);
    }
}
