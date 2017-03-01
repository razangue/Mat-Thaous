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
                    return Resource.Drawable.hotDogGroup3;
            }
        }
    }
}