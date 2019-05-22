using FrameworkMVCRazor.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WAF.Engine;
using WAF.Engine.Content.MySite;
using WAF.Engine.Content.Native;
using WAF.Presentation.Web;

namespace FrameworkMVCRazor.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            var vm = new SearchViewModel();
            vm.Content = WAFContext.Request.GetContent<ArticleBase>();
            vm.Name = vm.Content.Name;
            vm.SearchResult = new List<SearchResult<HierarchicalContent>>();
            return View(vm);
        }
        
        public ActionResult Search(string searchString, int nid)
        {
            var vm = new SearchViewModel();

            var query = new IndexQuery<HierarchicalContent>();
            query.BodySearch = searchString;
            query.ClassIds = new List<int>() { ArticleBase.ContentClassId, HelloWorld.ContentClassId };
            query.AutoWildcards = true;
            query.PageSize = 20;
            query.PageIndex = 0;

            vm.SearchResult = WAFContext.Session.Search<HierarchicalContent>(query);
            vm.Content = WAFContext.Request.GetContent<ArticleBase>();
            vm.SearchString = searchString;

            return View("index", vm);
        }
    }
}