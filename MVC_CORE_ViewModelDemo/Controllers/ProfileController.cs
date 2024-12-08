using Microsoft.AspNetCore.Mvc;
using MVC_CORE_ViewModelDemo.Models;

namespace MVC_CORE_ViewModelDemo.Controllers
{
    public class ProfileController : Controller
    {
    
        public IActionResult Details()
        {
            // Simulating data from a database or service
            var user = new User
            {
                Id = 1,
                Name = "Prakash",
                Email = "prakash.trainer1@gmail.com"
            };

            var address = new Address
            {
                Street = "Miyapur",
                City = "Hyderabad",
                Country = "India"
            };

            // Map data to the ViewModel
            var viewModel = new UserProfileViewModel
            {
                UserId = user.Id,
                UserName = user.Name,
                Email = user.Email,
                Street = address.Street,
                City = address.City,
                Country = address.Country
            };

            return View(viewModel); // passing view model to view
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
