using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppFirstTimeMVC.Models.Data;

namespace WebAppFirstTimeMVC.Models.ViewModel
{
    public class ExampelViewModel
    {
        public string SomeText { get; set; }
        public bool IsActive { get; set; }
        public Gender GenderStatus { get; set; }
    }
}
