using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebAppVinyl.Models;

namespace WebAppVinyl.Controllers
{
    public class CartsController : Controller
    {

        private ApplicationDbContext context;

        public CartsController()
        {
            context = new ApplicationDbContext();
        }


        // GET: Carts
        public ActionResult Index()
        {
            var vinyls = context.Carts
            .Include(c => c.Vinyl.Genre)
            .Include(c => c.Vinyl.Label)
            .ToList();

            return View(vinyls);
        }


        public ActionResult Delete(int id)
        {
            var userId = User.Identity.GetUserId();

            var vinylNotWanted = context.Carts
                .Where(c => c.VinylId == id && c.BuyerId == userId)
                .SingleOrDefault();

            context.Carts.Remove(vinylNotWanted);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}