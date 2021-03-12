using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorManager.Models;

namespace VendorManager.Tests
{

  [TestClass]
  public class OrderTests
  {

    [TestMethod]

    public void OrderConstructor_CreatesOrderInstance_True()
    {
      string name = "Flour Purchase";
      string description = "10 bags of flour.";
      string price = "$300";
      string date = "04/05/20";
      string endingDate = "04/06/20";
      Order newOrder = new Order(name, description, price, date, endingDate);
      List<Order> newList = new List<Order> { newOrder };
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void FindOrder_ReturnsOrder_Order()
    {
      string name = "Flour Purchase";
      string description = "10 bags of flour.";
      string price = "$300";
      string date = "04/05/20";
      string endingDate = "04/06/20";
      Order newOrder = new Order(name, description, price, date, endingDate);
      List<Order> newList = new List<Order> { newOrder };
      Assert.AreEqual(Order.FindOrder(2), newOrder);
    }
    [TestMethod]
    public void ClearAll_ClearsOrders_Order()
    {
      string name = "Flour Purchase";
      string description = "10 bags of flour.";
      string price = "$300";
      string date = "04/05/20";
      string endingDate = "04/06/20";
      Order newOrder = new Order(name, description, price, date, endingDate);
      Order.ClearAll();
      Assert.AreEqual(Order.OrderInstances.Count, 0);
    }
  }
}


