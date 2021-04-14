using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppFirstTimeMVC.Models
{
    public interface IMessagesService
    {
        bool Save(string name, string email, string message);
        List<string[]> GetAll();
    }
}
