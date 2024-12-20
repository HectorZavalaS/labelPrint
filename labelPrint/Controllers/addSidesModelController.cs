﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using labelPrint.Models;

namespace labelPrint.Controllers
{
    public class addSidesModelController : Controller
    {
        private siixsem_main_dbEntities db = new siixsem_main_dbEntities();

        // GET: addSidesModel
        public ActionResult Index()
        {
            var siixsem_sidesModel_td = db.siixsem_sidesModel_td.Include(s => s.siixsem_models_t).Include(s => s.siixsem_sides_t);
            return View(siixsem_sidesModel_td.ToList());
        }

        // GET: addSidesModel/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            siixsem_sidesModel_td siixsem_sidesModel_td = db.siixsem_sidesModel_td.Find(id);
            if (siixsem_sidesModel_td == null)
            {
                return HttpNotFound();
            }
            return View(siixsem_sidesModel_td);
        }

        // GET: addSidesModel/Create
        public ActionResult Create()
        {
            ViewBag.se_id_model = new SelectList(db.siixsem_models_t, "se_id_model", "se_description");
            ViewBag.se_id_side = new SelectList(db.siixsem_sides_t, "se_id_side", "se_description");
            return View();
        }

        // POST: addSidesModel/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "se_id_detail,se_id_model,se_id_side,se_part_num_tr,se_int_part_num,se_cust_part_num,se_oracle_par_num")] siixsem_sidesModel_td siixsem_sidesModel_td)
        {
            if (ModelState.IsValid)
            {
                db.siixsem_sidesModel_td.Add(siixsem_sidesModel_td);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.se_id_model = new SelectList(db.siixsem_models_t, "se_id_model", "se_description", siixsem_sidesModel_td.se_id_model);
            ViewBag.se_id_side = new SelectList(db.siixsem_sides_t, "se_id_side", "se_description", siixsem_sidesModel_td.se_id_side);
            return View(siixsem_sidesModel_td);
        }

        // GET: addSidesModel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            siixsem_sidesModel_td siixsem_sidesModel_td = db.siixsem_sidesModel_td.Find(id);
            if (siixsem_sidesModel_td == null)
            {
                return HttpNotFound();
            }
            ViewBag.se_id_model = new SelectList(db.siixsem_models_t, "se_id_model", "se_description", siixsem_sidesModel_td.se_id_model);
            ViewBag.se_id_side = new SelectList(db.siixsem_sides_t, "se_id_side", "se_description", siixsem_sidesModel_td.se_id_side);
            return View(siixsem_sidesModel_td);
        }

        // POST: addSidesModel/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "se_id_detail,se_id_model,se_id_side,se_part_num_tr,se_int_part_num,se_cust_part_num,se_oracle_par_num")] siixsem_sidesModel_td siixsem_sidesModel_td)
        {
            if (ModelState.IsValid)
            {
                db.Entry(siixsem_sidesModel_td).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.se_id_model = new SelectList(db.siixsem_models_t, "se_id_model", "se_description", siixsem_sidesModel_td.se_id_model);
            ViewBag.se_id_side = new SelectList(db.siixsem_sides_t, "se_id_side", "se_description", siixsem_sidesModel_td.se_id_side);
            return View(siixsem_sidesModel_td);
        }

        // GET: addSidesModel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            siixsem_sidesModel_td siixsem_sidesModel_td = db.siixsem_sidesModel_td.Find(id);
            if (siixsem_sidesModel_td == null)
            {
                return HttpNotFound();
            }
            return View(siixsem_sidesModel_td);
        }

        // POST: addSidesModel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            siixsem_sidesModel_td siixsem_sidesModel_td = db.siixsem_sidesModel_td.Find(id);
            db.siixsem_sidesModel_td.Remove(siixsem_sidesModel_td);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}