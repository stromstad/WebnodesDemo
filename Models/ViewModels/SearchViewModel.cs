using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine;
using WAF.Engine.Content.Native;

namespace FrameworkMVCRazor.Models.ViewModels
{
    public class SearchViewModel
    {
        public string Name { get; set; }
        public string SearchString { get; set; }
        public List<SearchResult<HierarchicalContent>> SearchResult { get; set; }
        public ArticleBase Content { get; set; }
    }
}