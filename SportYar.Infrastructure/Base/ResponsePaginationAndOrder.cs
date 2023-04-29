using Microsoft.EntityFrameworkCore.Metadata.Internal;
using OfficeOpenXml.FormulaParsing.ExpressionGraph;
using System.Linq;
using System.Linq.Expressions;
using Expression = System.Linq.Expressions.Expression;

namespace SportYar.Infrastructure.Base
{
    public static class ResponsePaginationAndOrder
    {
        public static IQueryable<T> ResponseActions<T>(this IQueryable<T> values, int page, int pageSize, string orderByPropertyString, string? filterByPropertyString, string? filterByNameString, bool isDedescending)
        {

            var entityType = typeof(T);
            ValidateSortOrFilter(entityType, orderByPropertyString);
            var datas = values.CustomOrderBy(orderByPropertyString, isDedescending);
            if (filterByPropertyString is not null)
            {
                ValidateSortOrFilter(entityType, filterByPropertyString);
                datas = datas.WhereContains(filterByPropertyString, filterByNameString);
            }
            datas = datas.Skip((page - 1) * pageSize).Take(pageSize);
            return datas;
        }

        private static IQueryable<T> WhereContains<T>(this IQueryable<T> source, string propertyName, string value)
        {
            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, propertyName);
            var constant = Expression.Constant(value);
            var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });
            var call = Expression.Call(property, containsMethod, constant);
            var lambda = Expression.Lambda<Func<T, bool>>(call, parameter);
            return source.Where(lambda);
        }

        private static IQueryable<T> CustomOrderBy<T>(this IQueryable<T> source, string propertyName, bool isDescending)
        {
            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, propertyName);
            var convert = Expression.Convert(property, typeof(object));
            var expression = Expression.Lambda<Func<T, object>>(convert, parameter);
            var data = isDescending ? source.OrderByDescending(expression) : source.OrderBy(expression);
            return data;
        }
        private static void ValidateSortOrFilter(Type? entityType, string propertyName)
        {
            var filterByPropertey = entityType.GetProperties()
                .Where(p => !p.GetGetMethod().IsVirtual).FirstOrDefault(x => x.Name == propertyName);
            if (filterByPropertey is null)
                throw new ManagedException($"بر اساس {propertyName} نمیتوان فیلتر/سورت کرد");
        }



    }
}
