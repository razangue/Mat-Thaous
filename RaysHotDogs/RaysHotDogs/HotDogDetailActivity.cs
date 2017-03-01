using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using RaysHotDogs.Core.Model;
using RaysHotDogs.Core.Service;
using RaysHotDogs.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RaysHotDogs
{
    [Activity(Label = "Hot dog detail", MainLauncher = false)]
    public class HotDogDetailActivity : Activity
    {
        private ImageView hotDogImageView;
        private TextView hotDogNameTextView;
        private TextView shortDescriptionTextView;
        private TextView descriptionTextView;
        private TextView priceTextView;
        private EditText amountEditText;
        private Button cancelButton;
        private Button orderButton;

        private HotDog selectedHotDog;
        private HotDogDataService hotDogDataService;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.HotDogDetailView);
            hotDogDataService = new HotDogDataService();

            var selectedHotDogId = Intent.Extras.GetInt("selectedHotDogId");
            selectedHotDog = hotDogDataService.GetHotDogById(selectedHotDogId);
            FindViews();
            BindData();
            HandleEvents();
        }
        private void FindViews()
        {
            hotDogImageView = FindViewById<ImageView>(Resource.Id.hotDogImageView);
            hotDogNameTextView = FindViewById<TextView>(Resource.Id.hotDogNameTextView);
            shortDescriptionTextView = FindViewById<TextView>(Resource.Id.shortDescriptionTextView);
            descriptionTextView = FindViewById<TextView>(Resource.Id.descriptionTextView);

            priceTextView = FindViewById<TextView>(Resource.Id.priceTextView);
            amountEditText = FindViewById<EditText>(Resource.Id.amountEditText);
            cancelButton = FindViewById<Button>(Resource.Id.cancelButton);
            orderButton = FindViewById<Button>(Resource.Id.orderButton);

        }
        private void BindData()
        {
            hotDogNameTextView.Text = selectedHotDog.Name;
            shortDescriptionTextView.Text = selectedHotDog.ShortDescription;
            descriptionTextView.Text = selectedHotDog.Description;
            priceTextView.Text = "Price: " + selectedHotDog.Price;

            hotDogImageView.SetImageResource(ImageHelper.GetImageFromName(selectedHotDog.ImagePath));
         }
        private void HandleEvents()
        {
            orderButton.Click += OrderButton_Click;
            cancelButton.Click += CancelButton_Click;
        }
        private void CancelButton_Click(Object sender, EventArgs e)
        {
            //TODO
        }
        private void OrderButton_Click(Object sender, EventArgs e) {
            var amount = Int32.Parse(amountEditText.Text);

            var intent = new Intent();
            intent.PutExtra("selectedHotDogId", selectedHotDog.HotDogId);
            intent.PutExtra("amount", amount);
            SetResult(Result.Ok, intent);
            this.Finish();
        }
    }
}