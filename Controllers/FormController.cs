using Microsoft.AspNetCore.Mvc;

public class FormController : Controller
{
    // specifiying the type of request and the route
    [HttpGet("")]
    // ViewResult is the type of return
    public ViewResult Index()
    {
        // View is a function in the MVC library
        return View("Index");
    }

    // specifiying the type of request and the route
    [HttpPost("results")]
    // ViewResult is the type of return
    public IActionResult Display(Form formSubmission)
    {
        // View is a function in the MVC library
        return View("Display", formSubmission);
    }
}