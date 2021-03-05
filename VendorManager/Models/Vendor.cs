using System.Collections.Generic;
namespace VendorManager.Models
{
  public class Vendor : Manager
  {

    public Vendor(string name, string description)
    {
      this.Name = name;
      Description = description;
      VendorInstances.Add(this);
      Id = VendorInstances.Count;

    }
    public static List<Vendor> GetVendors()
    {
      return VendorInstances;
    }

    public static Vendor FindVendors(int searchId)
    {
      return VendorInstances[searchId - 1];
    }
  }
}
