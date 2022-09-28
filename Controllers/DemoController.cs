using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HoangManhTungBTH.Models.Process;

namespace HoangManhTungBTH.Controllers;

public class DemoController : Controller
{
    private readonly ILogger<DemoController> _logger;

    public DemoController(ILogger<DemoController> logger)
    {
        _logger = logger;
    }
    GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();

    public GiaiPhuongTrinh Gpt { get => gpt; set => gpt = value; }

    public IActionResult Index() {
        return View();
    }
    [HttpPost]

    public IActionResult Index(string heSoA, string heSoB){
        double x = Convert.ToDouble(heSoA);
        double y = Convert.ToDouble(heSoB);
        string thongBao = gpt.GiaiPhuongTrinhBacNhat(x,y);

        ViewBag.mess = thongBao;
        return View(); 
    }
    [HttpPost]

    public class IActionResult Create(string heSoA, string heSoB, string heSoC)
    {
        double x = Convert.ToDouble(heSoA);
        double y = Convert.ToDouble(heSoB);
        double z = Convert.ToDouble(heSoC);
        string thongBao = gpt.GiaiPhuongTrinhBacHai(x, y, z);
        ViewBag.thongBao = thongBao;
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