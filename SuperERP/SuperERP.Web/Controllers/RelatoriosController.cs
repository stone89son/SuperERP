﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperERP.Web.Controllers
{
    public class RelatoriosController : Controller
    {
        //
        // GET: /Relatorios/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Relatorios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Relatorios/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Relatorios/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Relatorios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Relatorios/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Relatorios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Relatorios/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
