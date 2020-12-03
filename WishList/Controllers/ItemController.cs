using System;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;
using WishList.Models;
using System.Collections.Generic;

namespace WishList.Controllers 
{
    public class ItemController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult<Item> Index()
        {
            return View("Index", _context.Items);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {

            _context.Items.Add(item);
            _context.SaveChanges();
            return (RedirectToAction());
        }

        public IActionResult Delete(int Id)
        {

            _context.Items.RemoveRange(Index.ID);


            return (RedirectToAction());
        }
    }
}
