using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EvokeProjectWithApi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Redirect () => RedirectToRoute("Default");

    }
}