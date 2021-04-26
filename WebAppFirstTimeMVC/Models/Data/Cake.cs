using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirstTimeMVC.Models.Data
{
    public class Cake
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Detailes { get; set; }

        public int Amount { get; set; }//amount of people
    }
}
