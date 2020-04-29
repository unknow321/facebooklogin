using Android.Content;
using Android.Views;
using FacebookLogin.Droid;
using System;
using System.Collections.Generic;
using Xamarin.Facebook;
using Xamarin.Facebook.Login.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(FacebookLoginService))]
namespace FacebookLogin.Droid
{
    public class FacebookLoginService : Java.Lang.Object, IFacebookLoginService , IFacebookCallback
    {
        private LoginButton loginButton;

        public FacebookLoginService()
        {
            loginButton = new LoginButton(MainActivity.Activity);
            loginButton.SetPermissions(new List<string>() { "public_profile", "email" });
            loginButton.RegisterCallback(MainActivity.Activity.CallbackManager, this);
        }

        public void InitButton(StackLayout stackLayout)
        {
            stackLayout.Children.Add(loginButton);
        }

        public bool OnActivityResult(int requestCode, int resultCode, Intent data)
        {
            return true;
        }

        public void OnCancel()
        {
            
        }

        public void OnError(FacebookException error)
        {
            
        }

        public void OnSuccess(Java.Lang.Object result)
        {
           
        }
    }
}