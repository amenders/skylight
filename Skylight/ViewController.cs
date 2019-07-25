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
            try
            {
                var data = await asteroids.GetAsteroidByDateAsync(new DateTime(2019, 1, 10), new DateTime(2019, 1, 9));
                Console.WriteLine(data);
            } 
            catch (InvalidAsteroidParametersException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}