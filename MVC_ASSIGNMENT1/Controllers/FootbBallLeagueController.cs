using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assignment1.Models;

namespace MVC_Assignment1.Controllers
{
    public class FootBallLeagueController : Controller
    {  

        
        [HttpGet]
        [ActionName("Index")]
        public ActionResult Get_Index()
        {
            return View();
        }

        

        [HttpPost]
        [ActionName("Index")]
        public ActionResult Post_Index()
        {
            try
            {
                FootBallLeague footBallLeagueData = new FootBallLeague();
                UpdateModel(footBallLeagueData);

                if (ModelState.IsValid)
                {
                    FootballLeagueDetails footballLeagueDetails = new FootballLeagueDetails();
                    footballLeagueDetails.addMatchDetails(footBallLeagueData);

                    return RedirectToAction("Display");
                }
            }
            catch (Exception e)
            {
                Response.Write("Something is Wrong"+ e);
            }
            return View();
        }

        public String Display() {

            return "Details Successfully updated";
        
        }

    }
}