using System;
using System.Collections.Generic;
using System.Text;

namespace Drelanium.DesignPatterns.Behavioral.Chain_Of_Responsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);

        object Handle(object request);
    }

}
