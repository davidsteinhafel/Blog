using MyBlog_V1._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog_V1._0.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Create()
        //{
        //    return View();
        //}
        public ActionResult Edit()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Edit()
        //{
        //    return View();
        //}
        public ActionResult Delete()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Delete()
        //{
        //    return View();
        //}
    }
}