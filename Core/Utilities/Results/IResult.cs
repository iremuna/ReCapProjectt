using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public interface IResult
    {
        bool Success { get; }
        bool Message { get; }
    }
}
