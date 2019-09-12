using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Indecor.Models;
using Indecor.DAL;
using Indecor.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Indecor.Controllers
{
    public class HomeController : Controller
    {
        private IndecorDataBase _dbIndecor;
        public HomeController(IndecorDataBase indecorDataBase)
        {
            _dbIndecor = indecorDataBase;

        }
        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                BigSliders = _dbIndecor.BigSliders,
                WeekCategories = _dbIndecor.WeekCategories,
                Products = _dbIndecor.Products.Include(x =>x.Category).Include(n =>n.Sale)
              
                
            
            
            };
            ViewBag.Count = _dbIndecor.WeekCategories.Count();
            return View(homeViewModel);
        }
          
        
    }
}
