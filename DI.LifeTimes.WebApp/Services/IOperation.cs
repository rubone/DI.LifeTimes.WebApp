using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Services
{
    public interface IOperation
    {
        Guid Id { get; }
    }
}
