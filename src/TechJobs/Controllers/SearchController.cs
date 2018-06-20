using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }
        public IActionResult Results(string searchType, string searchTerm)
        {
            List<Dictionary<string, string>> values;

            if (searchType == "all")
            {
                values = JobData.FindByValue(searchTerm);
            }
            else
            {
                values = JobData.FindByColumnAndValue(searchType, searchTerm);
            }
            ViewBag.columns = ListController.columnChoices;
            ViewBag.jobs = values;
            ViewBag.title = "Jobs";
            return View();
        }



        // TODO #1 - Create a Results action method to process 
        // search request and display results

    }
}
