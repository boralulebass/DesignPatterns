using DesignPattern.IteratorPattern.IteratorPattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.IteratorPattern.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            VisitRouteMover visitRouteMover = new VisitRouteMover();
            List<string> strings = new List<string>();
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Almanya",
                CityName = "Berlin",
                VisitPlaceName = "Berlin Kapısı"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Fransa",
                CityName = "Paris",
                VisitPlaceName = "Eyfel"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "İtalya",
                CityName = "Venedil",
                VisitPlaceName = "Gondol"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "İtalya",
                CityName = "Roma",
                VisitPlaceName = "Kolezyum"
            });
            visitRouteMover.AddVisitRoute(new VisitRoute
            {
                CountryName = "Çekya",
                CityName = "Prag",
                VisitPlaceName = "Meydan"
            });

            var iterator = visitRouteMover.CreateIterator();
            while(iterator.NextLocation())
            {
                strings.Add(iterator.CurrentItem.CountryName+iterator.CurrentItem.CityName+iterator.CurrentItem.VisitPlaceName);
            }
            ViewBag.v = strings;
            return View();
        }
    }
}
