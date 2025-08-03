using SehirProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SehirProje.Controllers
{
    public class HomeController : Controller
    {
        private Database1Entities1 db = new Database1Entities1();
        public ActionResult Index()
        {
            var sliders = db.slider_images.Take(3).ToList();
            return View(sliders);
        }

        [Authorize(Roles ="user,admin")]
        public ActionResult Population()
        {
            // id'ye göre azalan ( yani en son eklenenden ilk eklenene doğru )
            var populations = db.populations.OrderByDescending(x => x.Id).ToList();
            return View(populations);
        }

        [Authorize(Roles = "user,admin")]
        public ActionResult District()
        {
            // alfabetik sıralama (a->z)
            var districts = db.districts.OrderBy(x => x.district_name).ToList();
            return View(districts);

            // var districts = db.districts
            //    .OrderBy(d => d.Population)
            //    .Take(6)
            //    .ToList();  sadece 6 adet veri getirir, 
        }

        [Authorize(Roles = "user,admin")]
        public ActionResult Place()
        {
            var places = db.places.ToList();
            return View(places);
        }

        [Authorize(Roles = "admin")]
        public ActionResult Admin()
        {
            return View();
        }
    }
}