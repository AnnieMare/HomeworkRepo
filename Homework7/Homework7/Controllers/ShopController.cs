using Homework7.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Homework7.Controllers
{
    public class ShopController : Controller
    {
        private SqlConnection myConnection = new SqlConnection(Global.ConnectionString);
        public static List<ShopItemViewModel> ShopItemList = new List<ShopItemViewModel>();

        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }

        //view to display shop 
        public ActionResult ViewShop()
        {
           
            return View(ShopItemList);
        }

        //View Displays item adding page
        public ActionResult ViewAddItem()
        {
            return View();
        }

        //Add item to ShopViewModel list of items
        public ActionResult SaveNewItem(string ItemName, string ItemDescription, string ItemPrice, string QuantityAvailable)
        {
            //check for empty values 
            if (ItemName != null && ItemDescription != null && ItemPrice != null && QuantityAvailable != null)
            {
                //create new item
                ShopItemViewModel NewItem = new ShopItemViewModel(ItemName, ItemDescription, Convert.ToDouble(ItemPrice), Convert.ToInt32(QuantityAvailable));
                ShopItemList.Add(NewItem);
            }

            return RedirectToAction("ViewShop");
        }

        public ActionResult SortByName()
        {
            ShopItemList = ShopItemList.OrderBy(ShopItemList => ShopItemList.Name).ToList();
            return RedirectToAction("ViewShop");
        }
        public ActionResult SortByPrice()
        {
            ShopItemList = ShopItemList.OrderBy(ShopItemList => ShopItemList.Price).ToList();
            return RedirectToAction("ViewShop");
        }
        public ActionResult SortByAvail()
        {
            ShopItemList = ShopItemList.OrderBy(ShopItemList => ShopItemList.QuantityAvailable).ToList();
            return RedirectToAction("ViewShop");
        }

        public ActionResult CountItems()
        {
            int NumItems = ShopItemList.Count();


            return RedirectToAction("ViewShop");
        }

        ///PART 2
        //View to display Table 
       
        public ActionResult ViewPart2()
        {
            return View();
        }

        //do insert
        public ActionResult DoInsert(string ItemName, string ItemDescription, string ItemPrice, string QuantityAvailable)
        {
            try
            {
                SqlCommand Insert = new SqlCommand("Insert into ShopItem VALUES('" + ItemName + "' , '" + ItemDescription + "', '" + Convert.ToDouble(ItemPrice) + "', '" + Convert.ToInt32(QuantityAvailable)+ "')", myConnection);     
                myConnection.Open();
                ViewBag.Message = "Succes: " +Insert.ExecuteNonQuery()+ " number or rows added.";
                myConnection.Close();

                //create new item
                ShopItemViewModel NewItem = new ShopItemViewModel(ItemName, ItemDescription, Convert.ToDouble(ItemPrice), Convert.ToInt32(QuantityAvailable));
                ShopItemList.Add(NewItem);


            }
            catch (Exception err)
            {
                ViewBag.Message = err.Message;
                myConnection.Close();
            }
           

            return RedirectToAction("ViewShop");
        }

      
    }
   
}