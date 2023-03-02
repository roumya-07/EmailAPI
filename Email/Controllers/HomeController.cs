using Email.Model;
using Email.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Email.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        Uri baseAdd = new Uri("http://localhost:30808/api");

        HttpClient client;

        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
            client = new HttpClient();
            client.BaseAddress = baseAdd;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}