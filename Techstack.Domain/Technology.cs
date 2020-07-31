using System;
using System.Collections.Generic;
using System.Text;

namespace TechStackApp.Domain
{
   public class Technology
    {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public TechStack Techstack { get; set; }
    public int TechStackId { get; set; }

    }
}
