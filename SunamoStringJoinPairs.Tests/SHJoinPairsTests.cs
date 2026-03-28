namespace SunamoStringJoinPairs.Tests;

/// <summary>
/// Tests for <see cref="SHJoinPairs"/> class.
/// </summary>
public class SHJoinPairsTests
{
    /// <summary>
    /// Tests that JoinPairs with default delimiters joins a single pair correctly.
    /// </summary>
    [Fact]
    public void JoinPairs_DefaultDelimiters_SinglePair_ReturnsExpected()
    {
        var result = SHJoinPairs.JoinPairs(parts: new[] { "key", "value" });

        Assert.Equal("key;value;", result);
    }

    /// <summary>
    /// Tests that JoinPairs with default delimiters joins multiple pairs correctly.
    /// </summary>
    [Fact]
    public void JoinPairs_DefaultDelimiters_MultiplePairs_ReturnsExpected()
    {
        var result = SHJoinPairs.JoinPairs(parts: new[] { "key1", "value1", "key2", "value2" });

        Assert.Equal("key1;value1;key2;value2;", result);
    }

    /// <summary>
    /// Tests that JoinPairs with custom delimiters uses them correctly.
    /// </summary>
    [Fact]
    public void JoinPairs_CustomDelimiters_ReturnsExpected()
    {
        var result = SHJoinPairs.JoinPairs("=", ",", "key1", "value1", "key2", "value2");

        Assert.Equal("key1=value1,key2=value2,", result);
    }

    /// <summary>
    /// Tests that JoinPairs with empty parts array returns an empty string.
    /// </summary>
    [Fact]
    public void JoinPairs_EmptyParts_ReturnsEmptyString()
    {
        var result = SHJoinPairs.JoinPairs(parts: Array.Empty<string>());

        Assert.Equal(string.Empty, result);
    }

    /// <summary>
    /// Tests that JoinPairs with custom delimiters and empty parts returns an empty string.
    /// </summary>
    [Fact]
    public void JoinPairs_CustomDelimiters_EmptyParts_ReturnsEmptyString()
    {
        var result = SHJoinPairs.JoinPairs("=", ",");

        Assert.Equal(string.Empty, result);
    }

    /// <summary>
    /// Tests that JoinPairs correctly handles empty string elements.
    /// </summary>
    [Fact]
    public void JoinPairs_EmptyStringElements_ReturnsDelimitersOnly()
    {
        var result = SHJoinPairs.JoinPairs("=", ",", "", "");

        Assert.Equal("=,", result);
    }
}
