﻿using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(65.99);
            ViewBag.v4 = netflixPlans.Content("Film/Dizi");
            ViewBag.v5 = netflixPlans.Resolution("480px");
            return View();
        }
        public IActionResult StandartPlanIndex()
        {
            NetflixPlans netflixPlans = new StandardPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlans.CountPerson(3);
            ViewBag.v3 = netflixPlans.Price(85.99);
            ViewBag.v4 = netflixPlans.Content("Film/Dizi");
            ViewBag.v5 = netflixPlans.Resolution("1080px");
            return View();
        }
        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new UltraPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(5);
            ViewBag.v3 = netflixPlans.Price(100.99);
            ViewBag.v4 = netflixPlans.Content("Film/Dizi/Belgesel/");
            ViewBag.v5 = netflixPlans.Resolution("4K");
            return View();
        }
    }
}
