using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BookStore.Domain.Entities;

namespace BookStore.Application
{
    public interface IBookSpecification
    {
        Expression<Func<Book, bool>> ToExpression();

        bool IsSatisfiedBy(Book entity);

        void UpdateProperties(bool allBooks, string byAuthor, string byPublisher, string title);
    }
}
