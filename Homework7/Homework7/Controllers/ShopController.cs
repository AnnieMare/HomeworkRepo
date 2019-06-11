using Homework7.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework7.Controllers
{
    public class ShopController : Controller
    {
        public static List<ShopItemViewModel> ShopItemList = new List<ShopItemViewModel>();

        // GET: Shop
        public ActionResult Index()
        {
            ShopItemViewModel Item1 = new ShopItemViewModel("Belt", "Leather WW2 Nazi belt", 500, 5);
            ShopItemViewModel Item2 = new ShopItemViewModel("Tunic", "Officers Tunic ww2", 800, 3);
            ShopItemViewModel Item3 = new ShopItemViewModel("K98 Rifle", "Rifle with wooden stock", 1500, 7);
            ShopItemList.Add(Item1);
            ShopItemList.Add(Item2);
            ShopItemList.Add(Item3);
            return RedirectToAction("ViewShop");
        }

        //view to display shop 
        public ActionResult ViewShop()
        {
           
            return View();
        }

        //View Displays item adding page
        public ActionResult ViewAddItem()
        {
            return View();
        }

        //Add item to ShopViewModel list of items
        public ActionResult SaveNewItem(string ItemName, string ItemDescription, double ItemPrice, int QuantityAvailable)
        {
            ShopItemViewModel NewItem = new ShopItemViewModel(ItemName, ItemDescription, ItemPrice, QuantityAvailable);
            ShopItemList.Add(NewItem);


            return RedirectToAction("ViewShop");
        }

    }
   
}