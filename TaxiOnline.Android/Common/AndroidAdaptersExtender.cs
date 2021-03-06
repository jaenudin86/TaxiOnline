﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TaxiOnline.Logic.Common;
using TaxiOnline.ClientAdapters.Android.Services;
using Android.Preferences;

namespace TaxiOnline.Android.Common
{
    public class AndroidAdaptersExtender : AdaptersExtender
    {
        private const string ServerEndPointName = "ServerEndPoint";

        public AndroidAdaptersExtender(ISharedPreferences preferences)
            : base(new AndroidServicesFactory(preferences))
        {

        }
    }
}