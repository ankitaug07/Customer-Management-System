using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Customer_Management_System.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsCpmplete { get; set; }
        public DateTime CompletedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public long UpdatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long DeletedBy { get; set; }
        public DateTime DeletedAt { get; set; }




    }
}