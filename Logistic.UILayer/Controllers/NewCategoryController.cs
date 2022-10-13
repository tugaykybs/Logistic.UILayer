﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logistic.UILayer.Models;
namespace Logistic.UILayer.Controllers
{
    public class NewCategoryController : Controller
    {
        DBLogisticEntities db = new DBLogisticEntities();
      
        public ActionResult Index()
        {
            var values = db.TblCategory.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(TblCategory p)
        {
            p.CategoryStatus = true;
            db.TblCategory.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
           
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = db.TblCategory.Find(id);
            db.TblCategory.Remove(values);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = db.TblCategory.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCategory(TblCategory p)
        {
            var values = db.TblCategory.Find(p.CategoryID);
            values.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}