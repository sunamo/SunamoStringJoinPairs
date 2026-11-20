namespace SunamoStringJoinPairs;

/// <summary>
/// Represents the SH join pairs type.
/// </summary>
public class SHJoinPairs
{
    /// <summary>
    /// Join pairs.
    /// </summary>
    /// <param name="parts">The parts.</param>
    /// <returns>The join pairs result.</returns>
    public static string JoinPairs(params string[] parts)
    {
        return JoinPairs(";", ";", parts);
    }

    /// <summary>
    /// Join pairs.
    /// </summary>
    /// <param name="firstDelimiter">The first delimiter.</param>
    /// <param name="secondDelimiter">The second delimiter.</param>
    /// <param name="parts">The parts.</param>
    /// <returns>The join pairs result.</returns>
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
