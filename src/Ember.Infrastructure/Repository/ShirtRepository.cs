using Ember.Domain.Interfaces;
using Ember.Domain.Models;
using Ember.Infrastructure.Context;

namespace Ember.Infrastructure.Repository
{
  public class ShirtRepository : Repository<Shirt>, IShirtRepository
  {
    public ShirtRepository(EmberContext context) : base(context)
    {
    }
  }
}