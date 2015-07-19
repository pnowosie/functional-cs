using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using LanguageExt;

//@msdn: https://msdn.microsoft.com/en-us/library/system.collections.immutable(v=vs.111).aspx
namespace Functional_Cs
{
    using static System.Diagnostics.Debug;
    using static LanguageExt.Prelude;

    class _01_its_not_only_about_functions
    {
        public _01_its_not_only_about_functions()
        {
            //////////////////////////////////////////////////////////////////////////////////////
            // With LangExt we gain access to some handy collections
            IImmutableList<int> list = ImmutableList.Create(1, 2, 3);

            IImmutableQueue<int> queue = ImmutableQueue.Create(1, 2, 3);
            // Enqueue, Dequeue, Peek ...

            // other types like:
            // IImmutableDictionary, IImmutableSet, IImmutableStack


            // with these collections we can use LINQ-equivallent, functional-looking methods:
            // map (Select), filter (Where), exists (Any), reduce (Aggregate), zip (Zip), max, min, sum...


            //////////////////////////////////////////////////////////////////////////////////////
            // Unit: empty value, like void, but you can have value of it
            var @void = Unit.Default;
            

            //////////////////////////////////////////////////////////////////////////////////////
            // Tuple (krotki)
            var one = tuple(1, "one");
            map(one, (fst, lst) => Console.WriteLine("Tuple: fst={0} snd={1}", fst, lst));


            //////////////////////////////////////////////////////////////////////////////////////
            // Pattern-matching for tuples, collections ...
            // But it is out of scope :) Read the handy manual ;)

        }
    }
}
