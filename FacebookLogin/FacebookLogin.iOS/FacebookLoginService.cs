using Facebook.LoginKit;
using FacebookLogin.iOS;
using Foundation;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Dependency(typeof(FacebookLoginService))]
namespace FacebookLogin.iOS
{
    public class FacebookLoginService : NSObject, ILoginButtonDelegate , IFacebookLoginService
    {
        private LoginButton loginButton;
        public FacebookLoginService()
        {
            loginButton = new LoginButton();
            loginButton.Delegate = this;
            loginButton.Permissions = (new List<string>() { "public_profile", "email"}).ToArray();
            loginButton.Completed += LoginButton_Completed;
        }

        private void LoginButton_Completed(object sender, LoginButtonCompletedEventArgs e)
        {
           
        }

        public void DidComplete(LoginButton loginButton, LoginManagerLoginResult result, NSError error)
        {
            
        }

        public void DidLogOut(LoginButton loginButton)
        {
            
        }

        public void InitButton(StackLayout stackLayout)
        {
            stackLayout.Children.Add(loginButton);
        }
    }
}