using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lost_woods.Models;
using lost_woods.Factory;

namespace lost_woods.Controllers
{
    public class TrailController : Controller
    {
        private readonly TrailFactory trailFactory;
 
        public TrailController()
        {
            trailFactory = new TrailFactory();
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Trails = trailFactory.FindAll();
            return View();
        }

        [HttpGet]
        [Route("trail/{trail_id}")]
        public IActionResult Show(int trail_id)
        {
            Trail trail = trailFactory.FindByID(trail_id);
            ViewBag.Trail = trail;
            float longitude = ViewBag.Trail.longitude;
            return View("Show", trail);
        }

        [HttpGet]
        [Route("trail/new")]
        public IActionResult AddTrail()
        {
            return View("AddTrail");
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddNew(Trail trail)
        {
            if(ModelState.IsValid)
            {
                trailFactory.Add(trail);
                return RedirectToAction("Index");
            }

            return View("AddTrail");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
