﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FacebookLogin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private IFacebookLoginService service;
        public MainPage()
        {
            InitializeComponent();
            service = DependencyService.Get<IFacebookLoginService>();
            service.InitButton(rootLayout);
        }
    }
}
