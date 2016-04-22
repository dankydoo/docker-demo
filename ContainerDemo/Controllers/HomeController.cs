using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace ContainerDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var con = new System.Data.SqlClient.SqlConnection("Data Source=kevins-kloud.eastus.cloudapp.azure.com;Initial Catalog=Northwind;User ID=sa;Password=thepassword2#"))
            {
                //var adapter = new SqlCommand("SELECT * FROM Categories", con);

                var command = con.CreateCommand();
                command.CommandText = "SELECT * FROM Categories";

                con.Open();
                var reader = command.ExecuteReader();

                int i = 0;
                while (reader.Read())
                {
                    ViewData["Data"] = ViewData["Data"] + " | " + reader.GetString(2);
                    i++;
                }

            }

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
