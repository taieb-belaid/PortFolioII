using Microsoft.AspNetCore.Mvc;
namespace PortFolioII.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    [Route("")]
    public ViewResult Index(){
        return View("Index");
    }
}