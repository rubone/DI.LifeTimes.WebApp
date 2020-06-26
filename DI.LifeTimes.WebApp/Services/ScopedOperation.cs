using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Services
{

    public interface IScopedOperation : IOperation
    {
    }

    public class ScopedOperation
    {
        public Guid Id { get; }
        public ScopedOperation()
        {
            Id = Guid.NewGuid();
        }
    }
}
