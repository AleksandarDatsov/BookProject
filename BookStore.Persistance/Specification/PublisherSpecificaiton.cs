using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BookStore.Application;
using BookStore.Domain.Entities;

namespace BookStore.Persistance.Specification
{
    public class PublisherSpecificaiton : Specification<Book>
    {
        private readonly string publisherName;

        public PublisherSpecificaiton(string publisherName)
        {
            this.publisherName = publisherName;
        }

        public override bool IsSatisfiedBy(Book b)
        {
            return !b.Publisher.Name.Contains(this.publisherName.ToLower());
        }

        public override Expression<Func<Book, bool>> ToExpression()
        {
            if (string.IsNullOrEmpty(this.publisherName))
            {
                return x => true;
            }

            return b => b.Publisher.Name.ToLower().Contains(this.publisherName.ToLower());
        }
    }
}
