using System;
using System.ComponentModel.DataAnnotations;

namespace Ember.Domain.Models
{
  public class Shirt
  {
      [Key]
      public Guid Id { get; set; }
      public string Color { get; set; }
      public string Size { get; set; }
      public DateTime CreatedAt { get; set; }
  }
}
