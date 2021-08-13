using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travel.Core.Interfaces
{
    public interface IBookInformation
    {
        public string Title { get; set; }

        public string Synopsis { get; set; }

        public string Pages { get; set; }

        public string EditorialName { get; set; }

        public string EditorialHeadquarters { get; set; }

        public ICollection<string> Authors { get; set; }
    }
}
