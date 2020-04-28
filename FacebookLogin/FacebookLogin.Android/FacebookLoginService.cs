using Android.Content;
using Android.Views;
using FacebookLogin.Droid;
using System;
using Xamarin.Facebook;
using Xamarin.Facebook.Login;
using Xamarin.Facebook.Login.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: Dependency(typeof(FacebookLoginService))]
namespace FacebookLogin.Droid
{
    public class FacebookLoginService : Java.Lang.Object, IFacebookLoginService , ICallbackManager, IFacebookCallback
    {
        private LoginButton loginButton;
        private ICallbackManager mCallbackManager;
        private IFacebookCallback facebookCallback;

        public FacebookLoginService()
        {
            loginButton = new LoginButton(Android.App.Application.Context);
            loginButton.RegisterCallback(this, this);


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