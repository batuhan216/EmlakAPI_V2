using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakAPI_V2.Application.ViewModels.Users
{
    public class VM_Create_User
    {
        public bool IsAdmin { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }
    }
}
