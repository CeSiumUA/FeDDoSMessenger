﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Doppler.DependencyInjections;
using Doppler.iOS.DependencyInjections;
using Foundation;
using SharedTypes.Tokens;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetCurrentPlatform))]
namespace Doppler.iOS.DependencyInjections
{
    public class GetCurrentPlatform : IGetPlatform
    {
        PlatformType IGetPlatform.GetPlatform()
        {
            return PlatformType.iOS;
        }
    }
}