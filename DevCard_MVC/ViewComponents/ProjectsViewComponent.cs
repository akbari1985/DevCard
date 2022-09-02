using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"Taxi","Online Taxi","project-1.jpg","Snapp"),
                new Project(2,"food","Online Food","project-2.jpg","Foodi"),
                new Project(3,"School","Online School","project-3.jpg","Schooli"),
                new Project(4,"Nasa","Online Nasa","project-4.jpg","Nasa"),
            };
            return View("_Projects",projects);
        }
    }
}
