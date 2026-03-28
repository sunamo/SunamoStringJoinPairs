namespace SunamoStringJoinPairs;

/// <summary>
/// Provides methods for joining string pairs with configurable delimiters.
/// </summary>
public class SHJoinPairs
{
    /// <summary>
    /// Joins string pairs using semicolons as both delimiters.
    /// Elements are paired sequentially: first with second, third with fourth, etc.
    /// </summary>
    /// <param name="parts">An even number of strings to be joined as pairs.</param>
    /// <returns>A string with all pairs joined using semicolons.</returns>
    public static string JoinPairs(params string[] parts)
    {
        return JoinPairs(";", ";", parts);
    }

    /// <summary>
    /// Joins string pairs using specified delimiters.
    /// Elements are paired sequentially: first element gets the first delimiter appended,
    /// second element gets the second delimiter appended, and so on.
    /// </summary>
    /// <param name="firstDelimiter">The delimiter appended after the first element of each pair.</param>
    /// <param name="secondDelimiter">The delimiter appended after the second element of each pair.</param>
    /// <param name="parts">An even number of strings to be joined as pairs.</param>
    /// <returns>A string with all pairs joined using the specified delimiters.</returns>
    public static string JoinPairs(string firstDelimiter, string secondDelimiter, params string[] parts)
    {
        var stringBuilder = new StringBuilder();
        for (var i = 0; i < parts.Length; i++)
        {
            stringBuilder.Append(parts[i++] + firstDelimiter);
            stringBuilder.Append(parts[i] + secondDelimiter);
        }

        return stringBuilder.ToString();
    }
}
