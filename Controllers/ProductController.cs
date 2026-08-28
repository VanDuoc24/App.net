using Microsoft.AspNetCore.Mvc;
using MyAppMVC.Models;

namespace MyAppMVC.Controllers;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>
        {
            new("Classic Noir", "Túi xách da dập vân", 1290000, "product-image-one"),
            new("Cherry Weekender", "Túi du lịch màu đỏ", 1490000, "product-image-two"),
            new("Urban Weave", "Túi đeo tay dệt họa tiết", 1350000, "product-image-three"),
            new("Ruby Carryall", "Túi công sở thanh lịch", 1590000, "product-image-four")
        };

        ViewData["Title"] = "Sản phẩm";
        return View(products);
    }
}