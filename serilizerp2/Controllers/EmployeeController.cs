using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using serilizerp2.Models;
using Emp;

namespace serilizerp2.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        DBemployee.seremployee();
        return View();
    }

    public IActionResult List()
    {
       List<Employee> list1= DBemployee.deemployee();

       ViewData["emp"]=list1;
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
