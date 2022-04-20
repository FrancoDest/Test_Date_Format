using NUnit.Framework;

namespace DateFormat;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        string testDate = "10/11/1977";
        string Deseado = "1977-11-10";
        string resultado= (TestDateFormat.ChangeFormat(testDate));
        Assert.AreEqual(TestDateFormat.ChangeFormat(testDate), Deseado);
    }
}