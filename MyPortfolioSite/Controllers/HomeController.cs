using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPortfolioSite.Models;
using System.Web;

namespace MyPortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "All about me!";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact me with any requests for bug reports, feature requests, or freelancing inquiries.";

            return View();
        }

        public IActionResult FatCatSplat()
        {
            ViewData["Message"] = "This is Fat Cat Splat.";
            ViewData["Instructions"] = @"Click the buttons to navigate through the UI. Use your Space Bar to jump!<br />
    <br />
    &emsp;Direct Link to GitHub Repository:   <a href=""https://github.com/hashr25/Fat-Cat-Splat/"" target=""_blank"">Fat Cat Splat</a>";
            

            return View();
        }

        public IActionResult LostInADungeon()
        {
            ViewData["Message"] = "This is Lost In A Dungeon, an exploration of Procedural Map Generation!";
            ViewData["Instructions"] = @"Here are the controls:<br />
Click any of the buttons on the screen to change map creation algorithms.<br />
    &emsp;Columned Room Generation - Large square room with columns throughout.<br />
    &emsp;Drunkard's Walk (Default): Algorithm walks a random path until it has taken enough steps.<br />
    &emsp;Binary Space Partition: Algorithm takes a set room size and splits it within a threshold until the map has rooms that are not too large.<br />
<br />
Controls:<br />
    &emsp;Movement        -   Standard arrow keys or WASD<br />
    &emsp;Toggle Mini-Map -   M<br />
    &emsp;Toggle Full-Map -   F<br />
    &emsp;Zoom Map In     -   -<br />
    &emsp;Zoom Map Out    -   =<br />
    &emsp;Crouch          -   C<br />
    &emsp;Walk            -   Left Shift<br />
    &emsp;Jump            -   Space Bar<br />
    <br />
    &emsp;Direct Link to GitHub Repository:   <a href=""https://github.com/hashr25/Lost-In-A-Dungeon/"" target=""_blank"">Lost In A Dungeon</a>";


            return View();
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult ThanksForConsidering()
        {
            return View();
        }

        public IActionResult Donate()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
