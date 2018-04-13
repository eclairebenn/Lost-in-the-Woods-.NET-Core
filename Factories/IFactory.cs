using lost_woods.Models;
using System.Collections.Generic;
namespace lost_woods.Factory
{
    public interface IFactory<T> where T : BaseEntity
    {
    }
}
