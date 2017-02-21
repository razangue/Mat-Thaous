using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace CoursesAndroid
{
    [Activity(Label = "Courses", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button buttonPrev;
        Button buttonNext;
        TextView textTtitle;
        ImageView imageCourse;
        TextView textDescription;
        int index = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
            textTtitle = FindViewById<TextView>(Resource.Id.textTitle);
            imageCourse= FindViewById<ImageView>(Resource.Id.imageCourse);
            textDescription = FindViewById<TextView>(Resource.Id.textDescription);

            buttonNext.Click += buttonNext_Click;
            buttonPrev.Click += buttonPrev_Click;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if(index == 1)
            {
                index = 5;
            }
            else
            {
                index--;
            }
            textTtitle.Text = "Prev Clicked";
            textDescription.Text = "The description that appears when Prev is clicked";
            loadPicture();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (index == 5)
            {
                index = 1;
            }
            else
            {
                index++;
            }
            textTtitle.Text = "Prev Clicked";
            textDescription.Text = "The description that appears when Next is clicked";
            loadPicture();
        }

        private void loadPicture() {
            switch (index) {
                case 1:
                    imageCourse.SetImageResource(Resource.Drawable.ps_top_naruto_card_01);
                    break;
                case 2:
                    imageCourse.SetImageResource(Resource.Drawable.ps_top_naruto_card_02);
                    break;
                case 3:
                    imageCourse.SetImageResource(Resource.Drawable.ps_top_naruto_card_03);
                    break;
                case 4:
                    imageCourse.SetImageResource(Resource.Drawable.ps_top_naruto_card_04);
                    break;
                case 5:
                    imageCourse.SetImageResource(Resource.Drawable.ps_top_naruto_card_05);
                    break;
            }
        }
    }
}

