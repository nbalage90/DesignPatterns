using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    abstract class InputExpression
    {
        public abstract void Interpret(Context context);
    }
}
