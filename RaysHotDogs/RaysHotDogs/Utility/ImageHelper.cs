using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using System.Net;
using Java.IO;
using Android.Content.Res;

namespace RaysHotDogs.Utility
{
    public class ImageHelper
    {
        public static int GetImageFromName(string imageName)
        {
            switch (imageName)
            {
                case "hotDog1":
                    return Resource.Drawable.hotDog1;
                case "hotDog2":
                    return Resource.Drawable.hotDog2;
                case "hotDog3":
                    return Resource.Drawable.hotDog3;
                case "hotDog4":
                    return Resource.Drawable.hotDog4;
                case "hotDog5":
                    return Resource.Drawable.hotDog5;
                case "hotDog6":
                    return Resource.Drawable.hotDog6;
                case "hotDogGroup1":
                    return Resource.Drawable.hotDogGroup1;
                case "hotDogGroup2":
                    return Resource.Drawable.hotDogGroup2;
                default:
                    return Resource.Drawable.FavoritesIcon;
            }
        }

        public static Bitmap GetImageBitmapFromFilePath(string fileName, int width, int height)
        {
            //First we get the dimension of the file on disk
            BitmapFactory.Options options = new BitmapFactory.Options {InJustDecodeBounds = true};
            BitmapFactory.DecodeFile(fileName, options);

            //Next we calculate the ratio that we need to resize the image by
            //in order to fit the requested dimensions.
            int outHeight = options.OutHeight;
            int outWidth = options.OutWidth;
            int inSampleSize = 1;
            if(outHeight> height || outWidth > width)
            {
                inSampleSize = outWidth > outHeight ? outHeight / height : outWidth / width;
            }
            //Now we will load the image and have BitmapFactory resize it for us.
            options.InSampleSize = inSampleSize;
            options.InJustDecodeBounds = false;
            Bitmap resizedBitmap = BitmapFactory.DecodeFile(fileName, options);

            return resizedBitmap;
        }
    }
}