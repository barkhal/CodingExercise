using System;
using System.Web.Http;

namespace Exercise.Controllers
{
    [RoutePrefix("api/HelloWorld")]
    public class API : ApiController
    {

        private IPrinter _printer;

        public API(IPrinter printer)
        {
            _printer = printer;
        }

        [Route("Print/{message}"), HttpGet]
        public void PrintHelloWorld(string message)
        {
            _printer.Print(message);
        }
    }

    public interface IPrinter
    {
        void Print(string message);
    }

    public class PrintOnConsole : IPrinter
    {
        public void Print(string message)
        {
        }
    }

    public class SaveIntoDatabase : IPrinter
    {
        public void Print(string message)
        {
        }
    }
}