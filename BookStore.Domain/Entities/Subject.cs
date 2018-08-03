using System.Collections.Generic;

namespace BookStore.Domain.Entities
{
    public class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }

        public ICollection<UserSubject> UserSubject { get; set; }
    }
}
