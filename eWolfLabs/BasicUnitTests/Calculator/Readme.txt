
internal int ParseText(string text)
{
    int comma = text.IndexOf(",");
    if (comma > -1)
    {
        text = text.Remove(comma);
    }

    int result;
    if (int.TryParse(text, out result))
    {
        return result;
    }
    return 0;
}

and the tests are

[TestCase("5", 5)]
[TestCase("15", 15)]
[TestCase("1,200", 1200)]
public void ShouldParseText(string text, int expected)
{
    AddNumbers an = new AddNumbers();

    int value = an.ParseText(text);
    value.Should().Be(expected);
}

[TestCase("a", 0)]
[TestCase("I love cats", 0)]
public void ShouldNotParseText(string text, int expected)
{
    AddNumbers an = new AddNumbers();

    int value = an.ParseText(text);
    value.Should().Be(expected);
}