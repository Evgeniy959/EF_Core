using System.Collections.Generic;

#nullable disable

namespace Ef_Core.Model
{
    public partial class Author
    {
        public Author()
        {
            TabBooks = new HashSet<Book>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Book> TabBooks { get; set; }
    }
}
