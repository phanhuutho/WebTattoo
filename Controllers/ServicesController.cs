using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTattoo.Models;

namespace WebTattoo.Controllers
{
    public class ServicesController : BaseController
    {
        // GET: Services
        public ActionResult Detail(string name)
        {
            var jsonServices = System.IO.File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/data-services.json"));
            var itemService = JsonConvert.DeserializeObject<List<DisplayModel>>(jsonServices).DefaultIfEmpty(new DisplayModel()).FirstOrDefault(x => x.Name == name);
            ViewBag.Title = itemService.Display;

            var htmlService = System.IO.File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/services/" + name + ".html"));
            htmlService = htmlService.Replace("{ImgService}", "/Content/images/services/" + name + ".jpg");
            htmlService = htmlService.Replace("{LinkPolicies}", "/policies.html");
            htmlService = htmlService.Replace("{LinkArtists}", "/artists.html");
            htmlService = htmlService.Replace("{LinkBookingAppointment}", ViewBag.LinkBookingAppointment);
            ViewBag.Service = htmlService;
            return View();
        }
    }
}