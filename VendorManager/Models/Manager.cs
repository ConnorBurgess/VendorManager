using System.Collections.Generic;

namespace VendorManager.Models
{
  abstract public class Manager
  {
    public string Name { get; protected set; }
    public int Id { get; protected set; }
    public string Description { get; protected set; }
    public string Date { get; protected set; }
    public string Price { get; protected set; }

  }
}