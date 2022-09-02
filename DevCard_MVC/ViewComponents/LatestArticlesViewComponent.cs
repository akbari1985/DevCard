using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"Asp","blog-post-thumb-card-1.jpg","ASP .net"),
                new Article(2,"PHP","blog-post-thumb-card-2.jpg","ASP .net"),
                new Article(3,"C#","blog-post-thumb-card-3.jpg","ASP .net"),
                new Article(4,"Python","blog-post-thumb-card-4.jpg","ASP .net"),
            };

            return View("_LatestArticles", articles);
        }
    }
}
