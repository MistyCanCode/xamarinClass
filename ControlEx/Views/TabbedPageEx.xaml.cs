﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControlEx.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPageEx : TabbedPage
    {
        public TabbedPageEx ()
        {
            InitializeComponent();
            new NavigationPage(new WelcomePage());
        }
    }
}