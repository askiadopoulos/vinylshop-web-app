using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppVinyl.Models;

namespace WebAppVinyl.ViewModels
{
    public class VinylsViewModel
    {
        public IEnumerable<Vinyl> VinylToBuy { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
    }
}