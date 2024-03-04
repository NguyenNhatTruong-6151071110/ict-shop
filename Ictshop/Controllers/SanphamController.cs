using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class SanphamController : Controller
    {
        Qlbanhang db = new Qlbanhang();

        // GET: Sanpham
        public ActionResult dtiphonepartial()
        {
            var Hangsx = db.Hangsanxuats.ToList();
            return PartialView(Hangsx);
        }
        public ActionResult dtsamsungpartial(int Mahang)
        {
            var ss = db.Sanphams.Where(n => n.Mahang == Mahang).Take(4).ToList();
            return PartialView(ss);
        }
        //public ActionResult dtxiaomipartial()
        //{
        //    return View();
        //}
        //public ActionResult dttheohang()
        //{
        //    var mi = db.Sanphams.Where(n => n.Mahang == 5).Take(4).ToList();
        //    return PartialView(mi);
        //}
        public ActionResult xemchitiet(int Masp=2)
        {
            var chitiet = db.Sanphams.SingleOrDefault(n=>n.Masp==2);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }

    }

}