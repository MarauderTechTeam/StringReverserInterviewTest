using StringReverserInterviewTest;

namespace UnitTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase("One two three four", "four three two One")]
    public void Test1(string input, string expected)
    {
        var reversed = SentenceReverser.ReverseSentence(input);
    }
}