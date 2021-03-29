using MapIntegration.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MapIntegration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            LocationLists model = new LocationLists();
            var locations = new List<Locations>()
            {
                new Locations(1, "Sundarban Courier Service (Pvt.) Ltd.","Kallyanpur, Dhaka", 23.77817533773455, 90.36103212881308),
                new Locations(2, "Sundarban Courier Service (Pvt.) Ltd.","Shop- 432 60ft Road, BNP Bazar More, Dhaka 1207", 23.777564919830862, 90.37077782455208),
                new Locations(3, "Sundarban Courier Service (Pvt.) Ltd.","House: 07, Road: 05, Block: Kha, Shekhertek, Dhaka 1207", 23.767518343884056, 90.35740450327043),
                new Locations(4, "Sundarban Courier Service (Pvt.) Ltd.","1/2, Desh Plaza, Kachukhet Bazar, Dhaka Cantonment, Dhaka 1206", 23.79359804057459, 90.3882068241756),
                new Locations(5, "Sundarban Courier Service (Pvt.) Ltd.","Kalwalapara Mosjid Market, Dhaka 1206", 23.798068953381165, 90.35355571530113),
                new Locations(6, "Sundarban Courier Service (Pvt.) Ltd.","Rajshahi, Rajshahi", 24.375553512353783, 88.60790365689355),
                new Locations(7, "Sundarban Courier Service (Pvt.) Ltd.","ঢাকা - চট্টগ্রাম মহাসড়ক, চট্টগ্রাম 4212", 22.36671274745603, 91.78238364709297),
            };
            model.LocationList = locations;
            return View(model);
        }
    }
}