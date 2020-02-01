using System;
using System.Collections.Generic;
using System.Text;

namespace Drelanium.DesignPatterns.Behavioral.Mediator
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }

}