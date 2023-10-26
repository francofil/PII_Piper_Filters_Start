using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;
using Ucu.Poo.Cognitive;

namespace CompAndDel.Pipes
{
    public class FilterContitional : IFilter
    {
        public bool face {get; private set; }

        public IPicture Filter(IPicture image)
        {
            CognitiveFace cog = new CognitiveFace();
            cog.Recognize(@"luke.jpg");
            return image;
        }
    }
}