using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HybridModelBinding;

namespace REST.Models
{
    public class Number
    {
        [HybridBindProperty(new[] {Source.Body, Source.Form, Source.QueryString, Source.Route })]
        public int? Until { get; set; }
        [HybridBindProperty(new[] { Source.Header, Source.QueryString, Source.Route })]
        public string Act { get; set; }

    }
}
