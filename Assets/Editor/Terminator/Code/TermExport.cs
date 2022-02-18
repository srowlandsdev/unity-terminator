using System;
using System.Collections.Generic;

namespace Terminator.Export
{
    [Serializable]
    public class TermData
    {
        public List<Term> terms = new();
    }

    [Serializable]
    public class Term
    {
        public string term;
        public int occurences;
        public int charLenth;
    }
}
