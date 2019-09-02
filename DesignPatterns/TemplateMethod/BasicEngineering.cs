using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class BasicEngineering
    {
        public void Papers()
        {
            Math();
            SoftSkills();
            SpecialPaper();
        }

        private void Math()
        {
            Console.WriteLine("Mathematics");
        }

        private void SoftSkills()
        {
            Console.WriteLine("SoftSkills");
        }

        public abstract void SpecialPaper();
    }
}
