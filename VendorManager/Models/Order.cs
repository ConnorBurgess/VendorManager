using System.Collections.Generic;
namespace VendorManager.Models
{
  public class Order : Manager
  {

    public Order(string name, string description, string price, string date, string endingDate)
    {
      Name = name;
      Price = price;
      Date = date + " - " + endingDate;
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
