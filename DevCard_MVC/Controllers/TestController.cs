using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {

        //public FileResult Index()
        //{
        //    //return File("~/TestFileTxt.txt", "text/htmle");

        //    var fileByte = System.IO.File.ReadAllBytes("WWWroot/TestFileTxt.txt");
        //    const string fileName = "TestFile.txt";
        //    return File(fileByte,MediaTypeNames.Text.Plain,fileName);
        //}



        //public EmptyResult Index()
        //{
        //    return null;
        //    return new EmptyResult();
        //}




        //public ContentResult Index()
        //{
        //    return Content("<h1> Hello Student </h1> <script>confirm('Ok?')</script>","text/html");
        //}




        //public JsonResult Index()
        //{
        //    return Json(new
        //    {
        //        id=1,
        //        name="hossein",
        //        job="Programmer",
        //        site="Pouya.com"
        //    });
        //}


        //public JavascriptResult Index()
        //{
        //    return new JavascriptResult("alert ('Salam')");
        //}



        //public RedirectResult Index()
        //{
        //    return Redirect("https://www.varzesh3.com");
        //}


        //public RedirectToActionResult Index()
        //{
        //    return RedirectToAction("Contact", "Home");
        //}



        //public IActionResult Index()
        //{
        //    return new OkResult();
        //    return new NotFoundResult();
        //    return new BadRequestResult();
        //    return new NoContentResult();
        //}




    }

    //public class JavascriptResult:ContentResult
    //{
    //    public JavascriptResult (string data)
    //    {
    //        Content = data;
    //        ContentType = "application/javascript";
    //    }

    //}
}
