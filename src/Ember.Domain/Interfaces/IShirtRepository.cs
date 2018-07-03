using System;
using System.Collections.Generic;
using Ember.Domain.Models;

namespace Ember.Domain.Interfaces
{
  public interface IShirtRepository : IRepository<Shirt>
  {
    Shirt GetById(Guid id);
  }
}