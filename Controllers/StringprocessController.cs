using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HoangManhTungBTH.Models.Process;

namespace HoangManhTungBTH.Controllers
{

    public class StringprocessController : Controller
    {
        Stringprocess strPro = new Stringprocess();

        public IActionResult RemoveWhiteSpace()
        {
            return View();
        }
        [HttpPost]

        public IActionResult RemoveRemainingWhiteSpace(string strInput)
        {
            ViewBag.Remove = strPro.RemoveRemainingWhiteSpace(strInput);
            return View();
        }

        public IActionResult LowToUpper()
        {
            return View();
        }
        [HttpPost]

        public IActionResult LowerToUpper(string strInput)
        {
            ViewBag.Upper = strPro.LowerToUpper(strInput);
            return View();
        }

        public IActionResult UpToLower()
        {
            return View();
        }
        [HttpPost]

        public IActionResult UpperToLower(string strInput)
        {
            ViewBag.Lower = strPro.UpperToLower(strInput);
            return View();
        }
        public IActionResult CapFirstCharacter()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CapitalizeOneFirstCharacter(string strInput)
        {
            ViewBag.CapFirstCharacter = strPro.CapitalizeOneFirstCharacter(strInput);
            return View();
        }

        public IActionResult CaprFirstCharacter()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CapitalizerOneFirstCharacter(string strInput)
        {
            ViewBag.CaprFirstCharacter = strPro.CapitalizerOneFirstCharacter(strInput);
        }

    }
}


