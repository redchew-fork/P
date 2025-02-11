using System;
using System.Collections.Generic;

namespace Plang.CSharpRuntime.Exceptions
{
    public class UnknownNamedTupleFieldAccess : Exception
    {
        public static UnknownNamedTupleFieldAccess FromFields(string expectedField, IEnumerable<string> actualFields)
        {
            string msg =
                "Field " + expectedField + " absent from NamedTuple with fields " + String.Join(",", actualFields);
            return new UnknownNamedTupleFieldAccess(msg);
        }

        private UnknownNamedTupleFieldAccess(string msg): base(msg)
        {

        }
    }
}
