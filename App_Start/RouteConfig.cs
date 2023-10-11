﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebTattoo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute("", "",
               new
               {
                   controller = "Home",
                   action = "Index"
               });

            routes.MapRoute(
                "Index", "index.html",
                new
                {
                    controller = "Home",
                    action = "Index"
                });

            routes.MapRoute(
                "Contact", "contact.html",
                new
                {
                    controller = "Home",
                    action = "Contact"
                });

            routes.MapRoute(
                "About", "about-us.html",
                new
                {
                    controller = "Home",
                    action = "About"
                });

            routes.MapRoute(
                "Services", "services.html",
                new
                {
                    controller = "Home",
                    action = "Services"
                });

            routes.MapRoute(
                "Gifts", "e-gift.html",
                new
                {
                    controller = "Home",
                    action = "Gifts"
                });

            routes.MapRoute(
                "Prices", "price-list.html",
                new
                {
                    controller = "Home",
                    action = "Prices"
                });

            routes.MapRoute(
                "Gallery", "gallery.html",
                new
                {
                    controller = "Home",
                    action = "Gallery"
                });

            routes.MapRoute(
                "Payment", "payment.html",
                new
                {
                    controller = "Home",
                    action = "Payment"
                });

            routes.MapRoute(
                "Process", "process.html",
                new
                {
                    controller = "Home",
                    action = "Process"
                });

            routes.MapRoute(
                "PaymentResponse", "payment-response.html",
                new
                {
                    controller = "Home",
                    action = "PaymentResponse"
                });

            routes.MapRoute(
                "Finish", "finish.html",
                new
                {
                    controller = "Home",
                    action = "Finish"
                });

            routes.MapRoute(
                "Artists", "artists.html",
                new
                {
                    controller = "Home",
                    action = "Artists"
                });

            routes.MapRoute(
                "Policies", "policies.html",
                new
                {
                    controller = "Home",
                    action = "Policies"
                });

            routes.MapRoute(
                "Aftercare", "aftercare.html",
                new
                {
                    controller = "Home",
                    action = "Aftercare"
                });

            routes.MapRoute(
                "FAQS", "faqs.html",
                new
                {
                    controller = "Home",
                    action = "FAQS"
                });

            routes.MapRoute(
                "Detail Artists", "artists/detail.html",
                new
                {
                    controller = "Artists",
                    action = "Detail"
                });

            routes.MapRoute(
                "Detail Services", "services/detail.html",
                new
                {
                    controller = "Services",
                    action = "Detail"
                });
        }
    }
}
