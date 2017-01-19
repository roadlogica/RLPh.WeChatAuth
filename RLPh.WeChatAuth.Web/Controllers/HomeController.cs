using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RLPh.WeChatAuth.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Newtonsoft.Json.Linq.JObject.Parse(json).ToString(Formatting.Indented)
            
            return View();
        }

        public ActionResult WeChatAuthResponse()
        {
            return View();
        }
    }
}