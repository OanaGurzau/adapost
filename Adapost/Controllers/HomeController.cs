using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adapost.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Response.Redirect("YourPage.aspx");
            
        }
    }
}