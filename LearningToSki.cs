using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine
{
    public class LearningToSki:Product
    {
        public LearningToSki() : base()
        {
            payment = new FreeFirstAidVideo();
            
        }
    }
}
