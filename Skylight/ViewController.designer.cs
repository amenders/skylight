﻿// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Skylight
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton AsteroidButton { get; set; }

        [Action ("AsteroidButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AsteroidButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (AsteroidButton != null) {
                AsteroidButton.Dispose ();
                AsteroidButton = null;
            }
        }
    }
}