using Facebook.LoginKit;
using FacebookLogin.iOS;
using Foundation;
using System;
using System.Collections.Generic;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Dependency(typeof(FacebookLoginService))]
namespace FacebookLogin.iOS
{
    public class FacebookLoginService : NSObject, IFacebookLoginService //ILoginButtonDelegate ,
    {
        private readonly LoginButton loginButton;
        public FacebookLoginService()
        {
            //loginButton = new LoginButton();
            //loginButton.Permissions = (new List<string>() { "public_profile", "email" }).ToArray();
            //loginButton.Completed += LoginButton_Completed;
        }

        private void LoginButton_Completed(object sender, LoginButtonCompletedEventArgs e)
        {
            var result = e.Result;
        }
        public void InitButton(StackLayout stackLayout)
        {
            LoginManager loginManager = new LoginManager();
            var hanlder = new LoginManagerLoginResultBlockHandler((result, error) =>
            {

            });
            var vc = UIApplication.SharedApplication.GetTopViewController();
            loginManager.LogIn(new string[2] { "public_profile", "email" }, vc, hanlder);
        }
    }
}