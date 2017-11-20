using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise.Controllers
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void PrintOnConsole()
        {
            IPrinter print = new PrintOnConsole();
            API controller = new API(print);
            controller.PrintHelloWorld("Print on console");
        }
        [TestMethod]
        public void SaveIntoDB()
        {
            IPrinter print = new SaveIntoDatabase();
            API controller = new API(print);
            controller.PrintHelloWorld("Save into database");
        }
    }
}