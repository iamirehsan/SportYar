using SportYar.Messages;
using Expression = System.Linq.Expressions.Expression;

namespace SportYar.Infrastructure.Base
{
    public static class ResponsePaginationAndOrder
    {
        public static IQueryable<T> ResponseActions<T>(this IQueryable<T> values, URLParameters parameters)
        {

            var entityType = typeof(T);
            ValidateSortOrFilter(entityType, parameters.OrderByPropertyString);
            var datas = values.CustomOrderBy(parameters.OrderByPropertyString, parameters.IsDescending);
            if (parameters.FilterByPropertyString is not null)
            {
                ValidateSortOrFilter(entityType, parameters.FilterByPropertyString);
                datas = datas.WhereContains(parameters.FilterByPropertyString, parameters.FilterByNameString);
            }
            datas = datas.Skip((parameters.Page - 1) * parameters.PageSize).Take(parameters.PageSize);
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
