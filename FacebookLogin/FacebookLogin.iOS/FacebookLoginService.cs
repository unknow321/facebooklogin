using Facebook.LoginKit;
using FacebookLogin.iOS;
using Foundation;
using System;
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