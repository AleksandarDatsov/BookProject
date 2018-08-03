using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BookStore.Application
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T o);

        ISpecification<T> And(ISpecification<T> specification);

        Expression<Func<T, bool>> ToExpression();
    }
}
