using NUnit.Framework;
namespace DateFormat
{
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
            string resultado = (TestDateFormat.ChangeFormat(testDate));
            Assert.AreEqual(Deseado, resultado);
        }
        [Test]
        public void Test2()
        {
            string testDate = "10/11/";
            string Deseado = "-11-10";
            string resultado = (TestDateFormat.ChangeFormat(testDate));
            Assert.AreEqual(Deseado, resultado);
        }
        [Test]
        public void Test3()
        {
            string testDate = "10//1977";
            string Deseado = "1977--10";
            string resultado = (TestDateFormat.ChangeFormat(testDate));
            Assert.AreEqual(Deseado, resultado);
        }
        [Test]
        public void Test4()
        {
            string testDate = "/11/1977";
            string Deseado = "1977-11-";
            string resultado = (TestDateFormat.ChangeFormat(testDate));
            Assert.AreEqual(Deseado, resultado);
        }
        public void Test_1()
        {
            string testDate = "10/11/1977";
            string Deseado = "11-10-77";
            string resultado = (TestDatenewFormat.ChangenewFormat(testDate));
            Assert.AreEqual(Deseado, resultado);
        }
    }
}