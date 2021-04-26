using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstTimeMVC.Models.Data;

namespace WebAppFirstTimeMVC.Models.ViewModel
{
    public class EditCake
    {
        public int Id { get; set; }

        public CreateCake CreateCake { get; set; }

        public EditCake(int id, Cake cake)
        {
            Id = id;
            this.CreateCake = new CreateCake() { Name = cake.Name, Amount = cake.Amount, Detailes = cake.Detailes };
        }

        public EditCake(int id, CreateCake createCake)
        {
            Id = id;
            this.CreateCake = createCake;
        }
    }
}
