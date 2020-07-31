using System;
using System.Collections.Generic;
using System.Text;

namespace TechStackApp.Domain
{
   public class TechStack
    {
        public TechStack()
        {
            Technologies = new List<Technology>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public List<Technology> Technologies { get; set; }
    }
}
