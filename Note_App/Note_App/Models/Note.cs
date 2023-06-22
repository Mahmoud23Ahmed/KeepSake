using System;
using System.Collections.Generic;

namespace Note_App.Models
{
    public partial class Note
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public DateTime Date { get; set; }
        public string? Body { get; set; }
        public int CategId { get; set; }

        public virtual Category Categ { get; set; } = null!;
    }
}
