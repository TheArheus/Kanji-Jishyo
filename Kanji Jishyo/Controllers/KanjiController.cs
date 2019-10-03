using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using Kanji_Jishyo.NewFolder1;
//using Kanji_Jishyo.Models;

namespace Kanji_Jishyo.Controllers
{
    public class KanjiController : Controller
    {
        KanjiJishyo1Entities db = new KanjiJishyo1Entities();
        SqlParameter param = new SqlParameter();

        public ActionResult KanjiPopular()
        {
            IEnumerable<PopularityKanji_Result> Popular = db.PopularityKanji().ToList();
            
            ViewBag.Item = Popular;
            return View();
        }

        public ActionResult KanjiJLPT()
        {
            IEnumerable<JLPTKanji_Result> JLPT = db.JLPTKanji_List().ToList();

            ViewBag.Item = JLPT;
            return View();
        }

        public ActionResult KanjiSchool()
        {
            IEnumerable<SchoolKanji_Result> School = db.SchoolKanji().ToList();

            ViewBag.Item = School;
            return View();
        }
        
        public ActionResult KanjiSearch()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult KanjiSearch(string kanjiOrValueItem, int? kanjiStrokesItem)
        {
            if(kanjiStrokesItem != null)
            {
                ViewBag.KanjiStrokesItem = kanjiStrokesItem;
            }
            if(kanjiOrValueItem != null)
            {
                ViewBag.KanjiOrValueItem = kanjiOrValueItem;
            }
            if(kanjiOrValueItem != null && kanjiStrokesItem != null)
            {
                ViewBag.KanjiOrValueItem = kanjiOrValueItem;
                ViewBag.KanjiStrokesItem = kanjiStrokesItem;
            }
            
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}