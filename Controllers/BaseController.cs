﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTattoo.Models;

namespace WebTattoo.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            var jsonText = System.IO.File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/info.json"));
            var dataInfo = JsonConvert.DeserializeObject<InfoModel>(jsonText);
            ViewBag.HyperLinkTell = dataInfo.HyperLinkTell;
            ViewBag.TextTell = dataInfo.TextTell;
            ViewBag.Name = dataInfo.Name;
            ViewBag.Logo = dataInfo.Logo ?? "";
            ViewBag.LinkBookingAppointment = dataInfo.LinkBookingAppointment ?? "";
            ViewBag.Address = dataInfo.Address;
            ViewBag.GooglePlus = dataInfo.GooglePlus;
            ViewBag.LinkGoogleMapAddress = dataInfo.LinkGoogleMapAddress;
            ViewBag.LinkIFrameGoogleMap = dataInfo.LinkIFrameGoogleMap;
            ViewBag.ShowCoupon = dataInfo.ShowCoupon;
            ViewBag.Coupons = dataInfo.Coupons ?? new List<CouponModel>();
            ViewBag.Prices = dataInfo.Prices ?? new List<PricesModel>();
            ViewBag.Telegram = dataInfo.Telegram ?? new SocialModel();
            ViewBag.Facebook = dataInfo.Facebook ?? new SocialModel();
            ViewBag.Instagram = dataInfo.Instagram ?? new SocialModel();
            ViewBag.Twitter = dataInfo.Twitter ?? new SocialModel();
            ViewBag.Youtube = dataInfo.Youtube ?? new SocialModel();

            var txtBusinessHours = System.IO.File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/business-hours.txt"));
            ViewBag.BusinessHours = txtBusinessHours;

            var txtHomeAboutUs = System.IO.File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/home-about-us.txt"));
            ViewBag.HomeAboutUs = txtHomeAboutUs;

            var txtAboutUs = System.IO.File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/about-us.txt"));
            ViewBag.AboutUs = txtAboutUs;

            var jsonHomeGallery = System.IO.File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/home-data-gallery.json"));
            var dataHomeGallery = JsonConvert.DeserializeObject<List<GalleryModel>>(jsonHomeGallery);
            ViewBag.HomeGallery = dataHomeGallery;

            var jsonGallery = System.IO.File.ReadAllText(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data/data-gallery.json"));
            var dataGallery = JsonConvert.DeserializeObject<List<GalleryModel>>(jsonGallery);
            ViewBag.Gallery = dataGallery;
        }
    }
}