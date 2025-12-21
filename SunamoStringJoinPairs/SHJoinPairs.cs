namespace SunamoStringJoinPairs;

public class SHJoinPairs
{
    public static string JoinPairs(params string[] parts)
    {
        return JoinPairs(";", ";", parts);
    }

    public static string JoinPairs(string firstDelimiter, string secondDelimiter, params string[] parts)
    {
        //InitApp.TemplateLogger.NotEvenNumberOfElements(type, "JoinPairs", @"args", parts);
        //InitApp.TemplateLogger.AnyElementIsNull(type, "JoinPairs", @"args", parts);

        var stringBuilder = new StringBuilder();
        for (var i = 0; i < parts.Length; i++)
        {
            stringBuilder.Append(parts[i++] + firstDelimiter);
            stringBuilder.Append(parts[i] + secondDelimiter);
        }

        return stringBuilder.ToString();
    }
}