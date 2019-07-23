using Foundation;
using System;
using UIKit;

namespace Skylight
{
    public partial class ViewController : UIViewController
    {
        private AsteroidService asteroids = new AsteroidService();

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        async partial void AsteroidButton_TouchUpInside(UIButton sender)
        {
            var data = await asteroids.GetAsteroidAsync(3542519);
            Console.WriteLine(data);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}