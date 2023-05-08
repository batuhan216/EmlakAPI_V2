using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakAPI_V2.Application.ViewModels.Products
{
    public class VM_Update_Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int ProductSize { get; set; }
    }
}
