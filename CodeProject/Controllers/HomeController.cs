using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeProject.Models;
using ServerSideAnalytics;
using ServerSideAnalytics.Extensions;

namespace CodeProject.Controllers
{
    public class HomeController : Controller
    {
        IAnalyticStore analyticStore;

        public HomeController(IAnalyticStore analyticStore)
        {
            this.analyticStore = analyticStore;
        }

        public async Task<IActionResult> Index()
        {
            var from = DateTime.MinValue;
            var to = DateTime.MaxValue;

            var stat = new WebStat
            {
                TotalServed = await analyticStore.CountAsync(from, to),
                UniqueVisitors = await analyticStore.CountUniqueIndentitiesAsync(from, to),
                DailyAverage = await analyticStore.DailyAverage(from, to),
                DailyServed = await analyticStore.DailyServed(from, to),
                HourlyServed = await analyticStore.HourlyServed(from, to),
                ServedByCountry = await analyticStore.ServedByCountry(from, to),
                UrlServed = await analyticStore.UrlServed(from, to),
                Requests = await analyticStore.InTimeRange(DateTime.Now - TimeSpan.FromDays(1), DateTime.Now)
            };
            return View(stat);
        }

        public async Task<ActionResult> Identity(string id)
        {
            return View(new WebStat
            {
                Identity = id,
                Requests = (await analyticStore.RequestByIdentityAsync(id)).ToArray(),
            });
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
