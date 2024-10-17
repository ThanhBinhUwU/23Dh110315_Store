using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _23Dh110315_Store.Models;

namespace _23Dh110315_Store.Areas.Admin.Controllers
{

        public class ProductsController : Controller
        {
            // GET: Admin/Products
            public ActionResult Index()
            {
                return View();
            }
        }
    }


