using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HST.Models;

namespace HST.Controllers
{
    public class Table_1Controller : Controller
    {
        private Database1Entities db = new Database1Entities();

        // GET: Table_1
        public ActionResult Index()
        {
            return View(db.Table_1.ToList());
        }

        // GET: Table_1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Exercise,RM15,WI15,RM10,WI10,RM5,WI5")] Table_1 table_1)
        {
            if (ModelState.IsValid)
            {
                db.Table_1.Add(table_1);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            return View(table_1);
        }

        // GET: Table_1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_1 table_1 = db.Table_1.Find(id);
            if (table_1 == null)
            {
                return HttpNotFound();
            }
            return View(table_1);
        }

        // POST: Table_1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Exercise,RM15,WI15,RM10,WI10,RM5,WI5")] Table_1 table_1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_1);
        }

        // GET: Table_1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_1 table_1 = db.Table_1.Find(id);
            if (table_1 == null)
            {
                return HttpNotFound();
            }
            return View(table_1);
        }

        // POST: Table_1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_1 table_1 = db.Table_1.Find(id);
            db.Table_1.Remove(table_1);
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

        public ActionResult Day1()
        {
            return View(db.GetOrder01());
        }
        public ActionResult Day2()
        {
            return View(db.GetOrder02());
        }
        public ActionResult Day3()
        {
            return View(db.GetOrder03());
        }
        public ActionResult Day4()
        {
            return View(db.GetOrder04());
        }
        public ActionResult Day5()
        {
            return View(db.GetOrder05());
        }
        public ActionResult Day6()
        {
            return View(db.GetOrder06());
        }
        public ActionResult Day7()
        {
            return View(db.GetOrder07());
        }
        public ActionResult Day8()
        {
            return View(db.GetOrder08());
        }
        public ActionResult Day9()
        {
            return View(db.GetOrder09());
        }
        public ActionResult Day10()
        {
            return View(db.GetOrder10());
        }
        public ActionResult Day11()
        {
            return View(db.GetOrder11());
        }
        public ActionResult Day12()
        {
            return View(db.GetOrder12());
        }
        public ActionResult Day13()
        {
            return View(db.GetOrder13());
        }
        public ActionResult Day14()
        {
            return View(db.GetOrder14());
        }
        public ActionResult Day15()
        {
            return View(db.GetOrder15());
        }
        public ActionResult Day16()
        {
            return View(db.GetOrder16());
        }
        public ActionResult Day17()
        {
            return View(db.GetOrder17());
        }
        public ActionResult Day18()
        {
            return View(db.GetOrder18());
        }
    }
}
