using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using LanguageExt;

namespace Functional_Cs
{
    using static System.Diagnostics.Debug;
    using static LanguageExt.Prelude;
    class _02_The_Option_type
    {
        public _02_The_Option_type()
        {
            // Option (Nullable, but for all, not just value types)
            var secondName = Option<string>.Some("Horacy");
            var otherName = Optional("Alojzy");

            Assert(secondName.IsSome == true);
            Assert(secondName.IsNone == false);
            // and if we don't have value, instead of null we can say
            Option<string> sndName = None;
            //////////////////////////////////////////////////////////////////////////////////////
            // real example: class Person

            //////////////////////////////////////////////////////////////////////////////////////
            // Optional: there is more 
            var price = 2.99m;
            Option<decimal> discountRate = None;
            var totalPrice = price * discountRate.IfNone(1.00m);     // 1 == no discount
            // decimal value = discountRate.IfNone(() => 1.00m) <- with handler
            // discountRate.IfSome( handler: decimal -> Unit ) : Unit

            // or more functional approach
            totalPrice = 2.99m * ifNone(discountRate, 1.00m);

            // or with pattern matching
            totalPrice = match(
                from priceOpt in Some(price)
                from discount in discountRate
                select priceOpt * discount,
                Some: identity,
                None: () => price
            );
            Assert(totalPrice == price);
        }
    }
}
