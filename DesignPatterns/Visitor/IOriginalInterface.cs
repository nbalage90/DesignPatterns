using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    public interface IOriginalInterface
    {
        void Accept(IVisitor visitor);
    }
}
