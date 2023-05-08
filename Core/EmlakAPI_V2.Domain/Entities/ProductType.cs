using EmlakAPI_V2.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakAPI_V2.Domain.Entities
{
    public class ProductType : BaseEntity
    {
        public string Name { get; set; }
        //DAHA SONRA EKLENECEK.
        //public ICollection<ProductProperty> Properties { get; set; }

    }
}
