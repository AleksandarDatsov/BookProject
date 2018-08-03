using System;

namespace BookStore.Domain.Entities
{
    public class Book
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public int AuthorId { get; set; }

        public Author Author { get; set; }

        public DateTime DateOfPublishing { get; set; }

        public int PublisherId { get; set; }

        public Publisher Publisher { get; set; }

        public int SubjectId { get; set; }

        public Subject Subject { get; set; }
    }
}
