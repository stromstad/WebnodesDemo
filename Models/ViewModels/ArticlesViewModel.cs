using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WAF.Engine.Content.MySite;
using WAF.Engine.Content.Native;

namespace FrameworkMVCRazor.Models.ViewModels
{
    public class ArticlesViewModel
    {
        public string Name { get; set; }
        public List<ArticleBase> Articles { get; set; }
        public HelloWorld Content { get; set; }
    }
}