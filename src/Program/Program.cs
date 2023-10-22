using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"beer.jpg");

            IFilter neg = new FilterNegative();
            IFilter grey = new FilterGreyscale();

            IPipe pipenull = new PipeNull();
            IPipe pipe2 = new PipeSerial(neg, pipenull);
            IPipe pipe1 = new PipeSerial(grey, pipe2);

            pipe1.Send(picture);
            IPicture image = pipe2.Send(picture);

            provider.SavePicture(image, @"beer2.jpg");

        }
    }
}
