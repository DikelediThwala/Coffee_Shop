using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Coffee_Shop.Models;
using Microsoft.EntityFrameworkCore;
using Coffee_Shop.Data;

namespace Coffee_Shop.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }
    // GET: Display the form to create a new review
    public IActionResult Create()
    {
        return View();
    }

    // POST: Handle the form submission to add a new review
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(BusinessReview review)
    {
        if (ModelState.IsValid)
        {
            review.CreatedAt = DateTime.Now; // Set the current date/time
            _context.BusinessReviews.Add(review);
            _context.SaveChanges();
            return RedirectToAction("Index"); // Redirect to the reviews list
        }
        return View(review); // Return the form view in case of validation failure
    }

    public IActionResult Index()
    {
        var reviews = _context.BusinessReviews.ToList();
        return View(reviews);
    }


    public IActionResult Shop()
    {
        return View();
    }
    public IActionResult LogIn()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
