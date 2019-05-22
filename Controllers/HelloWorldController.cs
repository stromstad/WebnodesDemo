using FrameworkMVCRazor.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAF.Engine.Content.MySite;
using WAF.Engine.Content.Native;
using WAF.Engine.Query.Native;
using WAF.Presentation.Web;

namespace FrameworkMVCRazor.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            var hw = WAFContext.Request.GetContent<HelloWorld>();
            var viewModel = new ArticlesViewModel();
            viewModel.Name = hw.Name;
            // viewModel.Articles = WAFContext.Session.GetContents<ArticleBase>(); // Ikke måten å gjøre det på.
            viewModel.Articles = WAFContext.Session.Query<ArticleBase>().OrderBy(AqlArticleBase.Name, false).Execute();
            viewModel.Content = hw;
            return View(viewModel);
        }
    }
}