using Microsoft.AspNetCore.Mvc;
namespace PortFolioII.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index(){
        return View("Index");
    }

    [HttpGet]
    [Route("projects")]
    public ViewResult Projects (){
        return View("Projects");
    }

    [HttpGet("contact")]
    public ViewResult Contact(){
        return View("Contact");
    }
}  