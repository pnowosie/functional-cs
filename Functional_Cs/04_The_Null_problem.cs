using System;
using System.Collections.Generic;
using System.Linq;

namespace Functional_Cs
{
    class _04_The_Null_problem
    {
        // A promise
        public interface IThridPartyMagicAlhemy
        {
            void ConvertMetalIntoGold();
        }

        // Is there any problem with nulls?
        public _04_The_Null_problem(IThridPartyMagicAlhemy alhemy)
        {
            // make me freekin rich, but
            if (alhemy == null)
                throw new ArgumentNullException("alhemy", "I hate you ThirdPartyMagic!");
            // ...
        }

        
    }
}
