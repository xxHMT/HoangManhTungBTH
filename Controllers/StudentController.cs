using HoangManhTungBTH.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoangManhTungBTH.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        List<Student> stdList = new List<Student>()
        {
            new Student {StudentID = 1, StudentName = "Hoàng Mạnh Tùng", StudentAge = 20},
            new Student {StudentID = 2, StudentName = "B", StudentAge = 21},
            new Student {StudentID = 3, StudentName = "C", StudentAge = 22},
            new Student {StudentID = 4, StudentName = "D", StudentAge = 23},
        };
        ViewData["StudentList"] = stdList;
        return View(stdList);
    }
    [HttpPost]

    public IActionResult Create (Student std)
    {
        string message = std.StudentID + "-";
        message += std.StudentName + "-";
        message += std.StudentAge + "-";
        ViewBag.TT = message;
        return View();
    }

}
