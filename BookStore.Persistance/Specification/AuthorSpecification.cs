using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BookStore.Application;
using BookStore.Domain.Entities;

namespace BookStore.Persistance.Specification
{
    public class AuthorSpecification : Specification<Book>
    {
        private readonly string authorName;

        public AuthorSpecification(string authorName)
        {
            this.authorName = authorName;
        }

        public override bool IsSatisfiedBy(Book book)
        {
            return !book.Author.Name.ToLower().Contains(this.authorName.ToLower());
        }

        public override Expression<Func<Book, bool>> ToExpression()
        {
            if (string.IsNullOrEmpty(this.authorName))
            {
                return x => true;
            }

            return book => book.Author.Name.ToLower().Contains(this.authorName.ToLower());
        }
    }
}
