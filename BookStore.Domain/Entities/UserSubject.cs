namespace BookStore.Domain.Entities
{
    public class UserSubject
    {
        public int Id { get; set; }

        public int SubjectId { get; set; }

        public User User { get; set; }

        public Subject Subject { get; set; }
    }
}
