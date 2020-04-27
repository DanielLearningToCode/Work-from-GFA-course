using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.ViewModels
{
    public class FoxesViewModel
    {
        public List<Fox> Foxes { get; set; }

        public FoxesViewModel(FoxService foxService)
        {
            Foxes = foxService.GetFoxes();
        }
    }
}
