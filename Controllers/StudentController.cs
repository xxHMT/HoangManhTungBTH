using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HoangManhTungBTH.Models;

namespace HoangManhTungBTH.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]

    public IActionResult Index(Student std)
    {
        ViewBag.mess = std.StudentID + "-" + std.StudentName + "-" + std.StudentAge;
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
