using System.Collections.Generic;

namespace ElQuecus.Models.WebModels
{
    internal class EchoNestArtistTerms
    {
        public List<Term> terms { get; set; }
    }

    internal class Term
    {
        public string name { get; set; }
    }
}
