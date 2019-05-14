using System;
using System.IO;
using System.Drawing;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySack;

namespace CrunchySack_WPF
{
    [Conversion]
    static public class ImageSourceExtensions
    {
        [Conversion]
        static public ImageSource Create(System.Drawing.Image image)
        {
            return Transfer.StreamViaMemory(
                s => image.Save(s, System.Drawing.Imaging.ImageFormat.Png),
                s => Create(s)
            );
        }

        [Conversion]
        static public ImageSource Create(Stream stream)
        {
            BitmapImage bitmap_image = new BitmapImage();

            try
            {
                bitmap_image.BeginInit();
                bitmap_image.CacheOption = BitmapCacheOption.OnLoad;
                bitmap_image.StreamSource = stream;
                bitmap_image.EndInit();

                return bitmap_image;
            }
            catch (Exception)
            {
            }

            return null;
        }
    }
}