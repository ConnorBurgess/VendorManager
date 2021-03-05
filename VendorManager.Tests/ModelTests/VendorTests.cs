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
      Vendor.ClearAll();
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

    //   public void AddVendor_AddsVendorToVendorInstances_VendorInstances()
    //   {
    //     string name01 = "French Bakery Vendor";
    //     string desc01 = "Delicious patisserie";
    //     Vendor newVendor1 = new Vendor(name01, desc01);
    //     Vendor newVendor2 = new Vendor(name01, desc01);
    //     List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
    //     List<Vendor> result = Vendor.GetVendors();
    //     CollectionAssert.AreEqual(newList, result);
    //   }
  }
}

