using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HoangManhTungBTH.Models;

namespace HoangManhTungBTH.Controllers;

public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]

    public IActionResult Index(Employee std)
    {
        ViewBag.mess = std.EmployeeID + "-" + std.EmployeeName + "-" + std.EmployeeAge;
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
