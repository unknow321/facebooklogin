using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace FacebookLogin.iOS
{
    public static class UiViewControllerExt
    {
        public static UIViewController GetTopViewController(this UIApplication app)
        {
            var viewController = app.KeyWindow.RootViewController;
            while (viewController.PresentedViewController != null)
                viewController = viewController.PresentedViewController;

            return viewController;
        }
    }
}