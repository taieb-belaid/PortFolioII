using Microsoft.AspNetCore.Mvc;
namespace PortFolioII.Controllers;

public class HomeController : Controller
{
    [HttpGet("")]
    public ViewResult Index(){
        return View("Index");
    }

    [HttpGet("projects")]
    public ViewResult Projects (){
        return View("Projects");
    }

    [HttpGet("contact")]
    public ViewResult Contact(){
        return View("Contact");
    }

    [HttpPost ("process")]
    public IActionResult Process(string Name, string Email, string Message){
        Console.WriteLine(Name);
        Console.WriteLine(Email);
        Console.WriteLine(Message);
        return RedirectToAction ("contact");
    }
}  