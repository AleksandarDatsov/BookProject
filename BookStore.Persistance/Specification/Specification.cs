using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using BookStore.Application;

namespace BookStore.Persistance.Specification
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public abstract Expression<Func<T, bool>> ToExpression();

        public abstract bool IsSatisfiedBy(T o);

        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndSpecification<T>(this, specification);
        }
    }
}
