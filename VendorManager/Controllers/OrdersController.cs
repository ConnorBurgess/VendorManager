using Microsoft.AspNetCore.Mvc;
using VendorManager.Models;
using System.Collections.Generic;

namespace VendorManager.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorid)
    {
      Vendor newVendor = Vendor.FindVendors(vendorid);
      return View(newVendor);
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Vendor.ClearAll(2);
      return View();
    }

    [HttpGet("/vendors/{vendorid}/orders/{orderid}")]
    public ActionResult Show(int vendorid, int orderid)
    {
      Order order = Order.FindOrder(orderid);
      Vendor vendor = Vendor.FindVendors(vendorid);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

     // This creates new Orders within a given Vendor, not new Vendors:
    [HttpPost("/vendors/{vendorid}/orders")]
    public ActionResult Create(int vendorid, string orderid, string orderTitle, string orderDescription, string orderPrice, string orderDate, string endingDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.FindVendors(vendorid);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate, endingDate);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.CurrentOrdersList;
      model.Add("order", newOrder);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

  }
}