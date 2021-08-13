using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Travel.Core.Interfaces;

namespace Travel.Core
{
    public class BookInformation : IBookInformation
    {
        public string Title { get; set; }

        public string Synopsis { get; set; }

        public string Pages { get; set; }

        public string EditorialName { get; set; }

        public string EditorialHeadquarters { get; set; }

        public ICollection<string> Authors { get; set; }
    }
}
