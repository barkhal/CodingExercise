using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace Exercise.Controllers
{
    public class WebApplication : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApiURL"].ToString());
                HttpResponseMessage response = client.GetAsync("Print/HelloWorld").Result;
                if (response.IsSuccessStatusCode)
                {
                    Response.Write("HelloWorld");
                }
                else
                {
                    Response.Write("No response form API");
                }
            }
            return View();
        }
    }
}