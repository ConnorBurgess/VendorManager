using System.Collections.Generic;
namespace VendorManager.Models
{
  public class Order : Manager
  {

    public Order(string name, string description, string price, string date)
    {
      this.Name = name;
      Description = description;
      OrderInstances.Add(this);
      Id = OrderInstances.Count;
    }
    public static Order FindOrder(int searchId)
    {
      return OrderInstances[searchId-1];
    }
  }
}
