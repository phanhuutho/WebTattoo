using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Newtonsoft.Json;
using WebTattoo.Models;

namespace WebTattoo.Controllers
{
    public class ArtistsController : BaseController
    {
        // GET: Artists
        public ActionResult Detail(string name)
        {
            var jsonArtists = System.IO.File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/data-artists.json"));
            var itemArtists = JsonConvert.DeserializeObject<List<DisplayModel>>(jsonArtists).DefaultIfEmpty(new DisplayModel()).FirstOrDefault(x => x.Name == name);
            ViewBag.Title = itemArtists.Display;

            var htmlArtist = System.IO.File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/artists/" + name + "/info.html"));
            htmlArtist = htmlArtist.Replace("{ImgArtists}", "/Content/images/artists/" + name + ".jpg");
            htmlArtist = htmlArtist.Replace("{LinkBookingAppointment}", ViewBag.LinkBookingAppointment);
            ViewBag.Artist = htmlArtist;
            return View();
        }
    }
}