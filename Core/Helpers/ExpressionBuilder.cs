using System.Linq.Expressions;

namespace sn_project_be.Core.Helpers;

public abstract class ExpressionBuilder<T, TFilterParams>
{
    public static Expression<Func<T, bool>> Build(string? filter)
    {
        if (string.IsNullOrWhiteSpace(filter))
        {
            return x => true; // Return a default expression if no filter is provided
        }

        var parameter = Expression.Parameter(typeof(T), "x");
        var body = ParseFilter(filter, parameter) ?? Expression.Constant(true);
        var lambda = Expression.Lambda<Func<T, bool>>(body, parameter);

        return lambda;
    }

    private static Expression? ParseFilter(string filter, ParameterExpression parameter)
    {
        // Split the filter string into individual conditions
        var conditions = filter.Split(',');
    
        Expression? finalExpression = null;
        foreach (var condition in conditions)
        {
            var parts = condition.Split('=');
            if (parts.Length != 2)
            {
                throw new ArgumentException("Invalid filter condition: " + condition);
            }
    
            var propertyName = parts[0];
            var propertyValue = parts[1];
            
            var propertyExist = typeof(TFilterParams).GetProperty(propertyName,
                System.Reflection.BindingFlags.IgnoreCase |
                System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Instance
            );
            if (propertyExist == null)
            {
                // Property doesn't exist, so skip this condition
                continue;
            }
            // Get the property of the object
            var property = Expression.Property(parameter, propertyName);
    
            // Convert property to string for case-insensitive comparison
            var toStringMethod = typeof(object).GetMethod("ToString");
            if (toStringMethod == null) continue;
            var propertyToString = Expression.Call(property, toStringMethod);
    
            // Create expression for the condition
            var value = Expression.Constant(propertyValue, typeof(string));
            var ignoreCase = Expression.Constant(StringComparison.OrdinalIgnoreCase);
            var conditionExpression = Expression.Call(propertyToString, "Contains", null, value, ignoreCase);
    
            // Combine condition expressions using 'And' logic
            finalExpression = finalExpression == null
                ? conditionExpression
                : Expression.AndAlso(finalExpression, conditionExpression);
        }
    
        return finalExpression;
    }
}