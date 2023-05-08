using EmlakAPI_V2.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakAPI_V2.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string CommentText { get; set; }
        public string CommentTitle { get; set; }
        public int Rating { get; set; }
        public bool IsEdited { get; set; } 
        // DAHA SONRA EKLENECEK.
        //public User User { get; set; }
    }
}
