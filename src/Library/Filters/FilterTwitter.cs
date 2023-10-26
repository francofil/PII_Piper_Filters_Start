using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using Ucu.Poo.Twitter;

namespace CompAndDel.Filters
{
    public class FilterTwitter : TwitterImage
    {
        public IPicture Filter(IPicture image)
        {
            // No es necesario implementar este método para la publicación en Twitter.
            // Si deseas, puedes lanzar una excepción o simplemente no hacer nada aquí.
            return image;
        }

        public string UploadImageTwitter(string text, string pathToImage)
        {
            var twitter = new TwitterImage();
            string result = twitter.PublishToTwitter(text, pathToImage);

            if (result == "OK")
            {
                return "Imagen publicada en Twitter con éxito.";
            }
            else
            {
                return "Error al publicar la imagen en Twitter: " + result;
            }
        }
    }
}