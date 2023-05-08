using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakAPI_V2.Application.ViewModels.ProductProperties
{
    public class VM_Create_ProductProperties
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string TextValue { get; set; }
        public bool BoolValue { get; set; }
    }
}
