﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageRecognition.CrossPlatform.UI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GlobalStyles : ResourceDictionary
    {
        public GlobalStyles()
        {
            InitializeComponent();
        }
    }
}