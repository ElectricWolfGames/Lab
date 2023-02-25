using System;
using System.Linq.Expressions;

namespace Examples.Reflection
{
    public class ExpressionTrees
    {
        public ExpressionTrees()
        {
        }

        internal void ShowTree()
        {
            ParameterExpression param = Expression.Parameter(typeof(int), "num");
            ConstantExpression constsValue = Expression.Constant(5, typeof(int));

            BinaryExpression binary = Expression.LessThanOrEqual(param, constsValue);

            Expression<Func<int, bool>> process =
                Expression.Lambda<Func<int, bool>>(
                binary,
                new ParameterExpression[] { param });

            Console.WriteLine("ParamName: " + param.Name);
            Console.WriteLine("constsValue: " + constsValue.Value);

            Console.WriteLine("Is 10 less than or equal to 5:" + process.Compile()(10));
            Console.WriteLine("Is 2 less than or equal to 5:" + process.Compile()(2));
            Console.WriteLine("Is 5 less than or equal to 5:" + process.Compile()(5));
        }
    }
}