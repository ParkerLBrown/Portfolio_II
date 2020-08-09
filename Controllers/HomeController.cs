using System;
using Microsoft.AspNetCore.Mvc;
namespace Portfolio_II
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public ViewResult AboutMe()
    {
      ViewBag.Name = "Jingle the Jester";
      ViewBag.Slogan = "I love Adventure!";
      ViewBag.Imgurl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRC9v_lpRkHSTSAxSAMCjLTOzO7lFm7zXK0vQ&usqp=CAU";
      return View();
    }

    [HttpGet("projects")]
    public IActionResult Projects()
    {
      return View("Projects");
    }

    [HttpGet("contact")]
    public IActionResult Contact()
    {
      return View("ContactMe");
    }
  }
}