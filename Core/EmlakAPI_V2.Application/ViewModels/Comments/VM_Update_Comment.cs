using EmlakAPI_V2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakAPI_V2.Application.ViewModels.Comments
{
    public class VM_Update_Comment
    {
        public string Id { get; set; }
        public string CommentText { get; set; }
        public string CommentTitle { get; set; }
        public int Rating { get; set; }
        public bool IsEdited { get; set; }
    }
}
