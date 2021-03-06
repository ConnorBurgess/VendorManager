using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorManager.Models;

namespace VendorManager.Tests
{

  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll(1);
      Vendor.ClearAll(2);
    }

    [TestMethod]

    public void VendorConstructor_CreatesVendorInstance_True()
    {
      string name01 = "French Bakery Vendor";
      string desc01 = "Delicious patisserie";
      Vendor newVendor = new Vendor(name01, desc01);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendors_ReturnsAllVendors_VendorInstances()
    {
      string name01 = "French Bakery Vendor";
      string desc01 = "Delicious patisserie";
      Vendor newVendor1 = new Vendor(name01, desc01);
      Vendor newVendor2 = new Vendor(name01, desc01);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetVendors();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void FindVendors_ReturnsVendor_Vendor()
    {
      string name01 = "French Bakery Vendor";
      string desc01 = "Delicious patisserie";
      Vendor newVendor1 = new Vendor(name01, desc01);
      Assert.AreEqual(Vendor.FindVendors(1), newVendor1);
    }
    [TestMethod]
    public void ClearAll_ClearsVendors_Vendor()
    {
      string name01 = "French Bakery Vendor";
      string desc01 = "Delicious patisserie";
      Vendor newVendor1 = new Vendor(name01, desc01);
      Vendor.ClearAll(1);
      Assert.AreEqual(Vendor.GetVendors().Count, 0);
    }

    [TestMethod]
    public void AddVendor_AddsOrderToCurrentOrdersList_OrderList()
    {
      string name = "Flour Purchase";
      string description = "10 bags of flour.";
      string price = "$300";
      string date = "04/05/20";
      Order newOrder = new Order(name, description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.CurrentOrdersList;

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetOrders_ReturnsAllOrders_CurrentOrderList()
    {
      string name = "Flour Purchase";
      string description = "10 bags of flour.";
      string price = "$300";
      string date = "04/05/20";
      Vendor newVendor = new Vendor(name, description);
      Order newOrder = new Order(name, description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.GetOrders();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}

