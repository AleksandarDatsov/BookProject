using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BookStore.Application;
using BookStore.Domain.Entities;

namespace BookStore.Persistance.Specification
{
    public class TitleSpecification : Specification<Book>
    {
        private readonly string title;

        public TitleSpecification(string title)
        {
            this.title = title;
        }

        public override bool IsSatisfiedBy(Book bo)
        {
            return !bo.Title.ToLower().Contains(this.title.ToLower());
        }

        public override Expression<Func<Book, bool>> ToExpression()
        {
            if (string.IsNullOrEmpty(this.title))
            {
                return x => true;
            }

            return bo => bo.Title.ToLower().Contains(this.title);
        }
    }
}
