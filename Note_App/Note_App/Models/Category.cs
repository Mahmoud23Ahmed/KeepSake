using System;
using System.Collections.Generic;

namespace Note_App.Models
{
    public partial class Category
    {
        public Category()
        {
            Notes = new HashSet<Note>();
        }

        public int Id { get; set; }
        public string? CategName { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
    }
}
