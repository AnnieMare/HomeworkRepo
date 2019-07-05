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
            return View();
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

        //public ActionResult SortByName()
        //{

        //}
        //public ActionResult SortByPrice()
        //{

        //}
        //public ActionResult SortByAvail()
        //{

        //}
        //public ActionResult SortByName()
        //{

        //}

    }
   
}