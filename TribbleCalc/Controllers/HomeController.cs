using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TribbleCalc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This tribble population growth calculator was created by Dallas Rosson.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Dallas Rosson.";

            return View();
        }

        [HttpPost]
        public ActionResult calculateTribbleNumbers(string hoursPassed)
        {
            @ViewBag.Tribbles = 0;


            if (hoursPassed != null)
            {
                try
                {
                    int hours = Convert.ToInt32(hoursPassed);


                    int tribbles = 1;
                    int i = 0;
                    while (i < hours)
                    {
                        tribbles = tribbles + (tribbles * 10);
                        i++;
                    }

                    @ViewBag.Tribbles = tribbles;
                }
                catch (FormatException e)
                {
                    // Improper input.
                    @ViewBag.Tribbles = 1;
                }
                
            }
            else
            {
                @ViewBag.Tribbles = 1;
            }

            return View("Index");

        }
    }
}


 /*               @using (Html.BeginForm("calculateTribbleNumbers", "HomeController", FormMethod.Post))
              {
                @Html.TextBox("HoursPassed")

                    <input type="submit" id="hoursPassed" value="Submit" />

               }
*/