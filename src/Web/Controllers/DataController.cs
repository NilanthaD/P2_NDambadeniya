using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Web.Models;

namespace Web.Controllers
{
    //source: https://www.youtube.com/watch?v=E7Voso411Vs
    //source: https://www.youtube.com/watch?v=Oggn1mlQsOM
    //source: https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-2.2

    public class DataController : Controller
    {
        //Get:/Data
        //Index view Data controller
        public IActionResult Index()
        {
            var data = new Data() { text = "Index for Data Controller" };
            return View(data);
        }

        //GET: /Data/ViewReturn
        // View as an action for Data controller
        public IActionResult GetView()
        {
            var data = new Data() { text = "Return view from the controller" };             
            return View(data);
        }

        //GET:/Data/TextContent
        //text return as an action for Data controller
        public ContentResult GetText()
        {
            return Content("This will return plan text");
        }

        // GET:/Data/GetJsonData
       // Json object return as an action for Data controller
        public IActionResult GetJosnData()
        {
            return Json(new { name = "Jone Pole", age = 35, city = "Maryville" });
        }

        //GET :/Data/GetHtml
        //HTML return as an action for Data controller

        public ActionResult GetHtml()
        {
            return Content("<!DOCTYPE html><body><html><h1>Get html return</h1></br><p>This GetHtml action will return html headder and a pharagraph.</p></body></html>", "text/html");
        }
    }
}