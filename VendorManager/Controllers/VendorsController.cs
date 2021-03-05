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
      string name01 = "French Bakery Vendor";
      string desc01 = "Delicious patisserie";
      Vendor newVendor1 = new Vendor(name01, desc01);
      List<Vendor> allVendors = Vendor.GetVendors();
      return View(allVendors);
    }

  }
}