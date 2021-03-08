using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorManager.Models;

namespace ToDoList.Controllers
{
  public class VendorsController : Controller
  {

    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetVendors();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    //Create a new Vendor
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }
      [HttpGet("/vendors/{id}")]
      public ActionResult Show(int id)
      {
        Dictionary<string, object> model = new Dictionary<string, object>();
        Vendor selectedCategory = Vendor.FindVendors(id);
        List<Order> vendorOrders = selectedCategory.CurrentOrdersList;
        model.Add("vendor", selectedCategory);
        model.Add("orders", vendorOrders);
        return View(model);
      }
  }
}