using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using Ucu.Poo.Twitter;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1 
            /*
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");

            //Creo los filtros
            IFilter filter1 = new FilterGreyscale(); // Primer filtro: Escala de grises
            IFilter filter2 = new FilterNegative();   // Segundo filtro: Negativo

            //Creo las IPipe
            IPipe pipe2 = new PipeSerial(filter2, new PipeNull()); // Pipe para el segundo filtro
            IPipe pipe1 = new PipeSerial(filter1, pipe2); // Pipe para el primer filtro

            //Uno los IPipe con las imagenes 
            //IPicture image1 =pipe2.Send(picture); // Aplicar el primer filtro
            IPicture image2 = pipe1.Send(picture); // Aplicar el segundo filtro

            //Guardo la imagen con los filtros aplicados 
            //provider.SavePicture(image1, @"lukeEditado.jpg");
            provider.SavePicture(image2, @"lukeEditado2.jpg");
           
            Console.WriteLine("Proceso completado."); //chequo que este realizando el codigo
            */


            //--------------------------------------------------------------------------------------------------------------------------
            //EJERCICIO 2

            /*
            
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"luke.jpg");

            provider.SavePicture(picture, "ImagenOriginal.jpg"); //guardo la imagen original como parte del proceso 
        
            // Crear y aplicar el filtro blanco y negro
            IFilter grey1 = new FilterGreyscale();
            IPicture grayscalePicture = grey1.Filter(picture);

            // Usar FilterGuardar para guardar la imagen en blanco y negro
            IFilter filterGuardar1 = new FilterGuardar("PathToGreyscaleImage.jpg");
            IPicture intermediatePicture = filterGuardar1.Filter(grayscalePicture);

            // Aplicar el filtro negativo
            IFilter neg2 = new FilterNegative();
            IPicture negativePicture = neg2.Filter(intermediatePicture);

            // Usar FilterGuardar para guardar la imagen negativa
            IFilter filterGuardar2 = new FilterGuardar("PathToNegativeImage.jpg");
            IPicture finalPicture = filterGuardar2.Filter(negativePicture);

            // Guardar la imagen final
            provider.SavePicture(finalPicture, "PathToFinalImage.jpg");
            */

            //----------------------------------------------------------------------------------------

            //Ejercicio 3
            var uploadTwitter = new FilterTwitter();
            string text = "anakin";
            string pathToImage = @"PathToFinalImage.jpg";
            Console.WriteLine(uploadTwitter.UploadImageTwitter(text, pathToImage));

        }
    }
}
