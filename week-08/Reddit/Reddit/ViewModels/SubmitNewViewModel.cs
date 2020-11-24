using System.Collections.Generic;

namespace Reddit.ViewModels
{
    public class SubmitViewModel
    {
        public ICollection<string> Users { get; set; }
        public SubmitViewModel()
        {
            Users = new List<string>();
        }
    }
}
