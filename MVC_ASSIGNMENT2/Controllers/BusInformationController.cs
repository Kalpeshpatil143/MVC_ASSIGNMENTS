using MVC_Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Assignment2.Controllers
{
    public class BusInformationController : Controller
    {
        
        [HttpGet]
        [ActionName("Index")]
        public ActionResult Get_Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult Post_Index() {

            BusInformation busInformationData = new BusInformation();

            // Model Binding, i.e. used to get the data from form and set the values
            UpdateModel(busInformation);

            if (ModelState.IsValid)
            {
                BusInformationDetails busInformationDetails = new BusInformationDetails();
                busInformationDetails.AddBusInformation(busInformationData);

                return RedirectToAction("Index");
            }
            return View();

        }
        
    }
}