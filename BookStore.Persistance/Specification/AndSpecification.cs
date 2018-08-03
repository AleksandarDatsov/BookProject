using System;
using System.Linq;
using System.Linq.Expressions;
using BookStore.Application;
using BookStore.Domain.Entities;

namespace BookStore.Persistance.Specification
{
    public class AndSpecification<T> : Specification<T>
    {
        private ISpecification<T> leftCondition;
        private ISpecification<T> rightCondition;

        public AndSpecification(ISpecification<T> left, ISpecification<T> right)
        {
            this.leftCondition = left;
            this.rightCondition = right;
        }

        public override bool IsSatisfiedBy(T о)
        {
            return this.leftCondition.IsSatisfiedBy(о)
                && this.rightCondition.IsSatisfiedBy(о);
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            Expression<Func<T, bool>> leftExpression = this.leftCondition.ToExpression();
            Expression<Func<T, bool>> rightExpression = this.rightCondition.ToExpression();

            var sum = Expression.AndAlso(leftExpression.Body, Expression.Invoke(rightExpression, leftExpression.Parameters[0]));
            return Expression.Lambda<Func<T, bool>>(sum, leftExpression.Parameters);
        }
    }
}