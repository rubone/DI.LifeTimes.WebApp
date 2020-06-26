using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Services
{
    public interface ITransientOperation : IOperation
    {

    }

    public class TransientOperation : ITransientOperation
    {
        public Guid Id { get; }

        public TransientOperation ()
        {
            Id = Guid.NewGuid();
        }
    }
}
