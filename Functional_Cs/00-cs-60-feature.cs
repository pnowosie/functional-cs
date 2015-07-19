using System;
using System.Collections.Generic;
using System.Linq;
using LanguageExt;


namespace Functional_Cs
{
    using static LanguageExt.Prelude;
    class _00_cs_60_feature
    {
        public _00_cs_60_feature()
        {
            // old C# 5.0 way:
            var id0 = Prelude.fun((string x) => x);

            // new C# 6.0, with 'using static' which allows us to treat static classes like namespaces 
            var id = fun((string x) => x);

            // but what's the deal?
            // because lambda type (and expression) cannot be infered

            // var id1 = (string x) => x;
            // Error CS0815  Cannot assign lambda expression to an implicitly - typed variable

            // instead we need declare the type explicitly
            Func<string, string> id1 = x => x;
            // Is this a problem at all? Well readability.

            // By the way - with LangExt we have Identity function
            Func<string, string> identity = identity<string>;
            // so we don't need to declare such function :) like I did above

            // and for Actions we have 
            Action<string> log = act((string msg) => Console.WriteLine(msg));
        }

        // Real usage example (but still just an example)
        //?? How does it work?
        public ILookup<char, string> Index(string text)
        {
            return text
                .ToLower()
                .Split()
                .ToLookup(
                    x => x.First(),                 // key selector
                    identity                        // element selector
                );
            //?? Where is the catch?
        }
    }
}
