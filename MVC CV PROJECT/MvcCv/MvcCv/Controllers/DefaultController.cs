using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;
namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        Db_CvEntities db = new Db_CvEntities();

        public ActionResult Index()
        {
            var degerler = db.Tbl_Hakkimizda.ToList();
            return View(degerler);
        }

        public PartialViewResult Deneyim()
        {
            var query = db.Tbl_Deneyimlerim.ToList();
            return PartialView(query);
        }

        public PartialViewResult Egitim()
        {
            var query = db.Tbl_Egitim.ToList();
            return PartialView(query);
        }

        public PartialViewResult Yeteneklerim()
        {
            var query = db.Tbl_Yeteneklerim.ToList();
            return PartialView(query);
        }

        public PartialViewResult Hobilerim()
        {
            var query = db.Tbl_Hobiler.ToList();

            return PartialView(query);
        }

        public PartialViewResult Sertifikalarım()
        {
            var query = db.Tbl_Sertifakalar.ToList();

            return PartialView(query);
        }

        [HttpGet]
        public PartialViewResult iletisim()
        {
            var query = db.Tbl_Iletisim.ToList();

            return PartialView(query);
        }


        [HttpPost]
        public JsonResult iletisim(Tbl_Iletisim p1)
        {
            var query = db.Tbl_Iletisim.Add(p1);
            p1.Tarih = DateTime.Now;
            db.SaveChanges();
            return Json(query, JsonRequestBehavior.AllowGet);

        }

    }
}