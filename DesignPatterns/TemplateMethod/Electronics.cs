using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class Electronics : BasicEngineering
    {
        public override void SpecialPaper()
        {
            Console.WriteLine("Digital Logic and Circuit Theory");
        }
    }
}
