using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Services
{
    public interface ISingletonOperation : IOperation
    {

    }

    public class SingleOperation : ISingletonOperation
    {
        public Guid Id { get;  }
        
        public SingleOperation()
        {
            Id = Guid.NewGuid();
        }
    }
}
