using System;
using System.Windows.Forms;

namespace HelpScreenApp
{
    public class HelpScreen : Form
    {
        private Button returnButton;
        private Button angelstreet;

        public HelpScreen()
        {
            Mouse.Show();
            returnButton.Click += OnClickReturn;
            angelstreet.Click += OnClickAngelStreet;
        }

        private void OnClickReturn(object sender, EventArgs e)
        {
            // Dispatch the equivalent of NavigationEvent.RETURN
            // (You'll need to implement this logic)
        }

        private void OnClickAngelStreet(object sender, EventArgs e)
        {
            string url = "http://angelstreetv2.blogspot.com/";
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occurred: " + ex.Message);
            }
        }

        // Add any other necessary methods or event handlers here
    }
}

package 
{
	import flash.display.MovieClip;
	import flash.display.SimpleButton;
	import flash.events.MouseEvent;
	import flash.ui.Mouse;
	import flash.net.*;
	
	public class HelpScreen extends MovieClip 
	{
		
		public function HelpScreen() {
			Mouse.show();
			returnButton.addEventListener( MouseEvent.CLICK, onClickReturn );
			angelstreet.addEventListener( MouseEvent.CLICK, onClickAngelStreet );
		}
		
		public function onClickReturn( event:MouseEvent ):void{
			dispatchEvent( new NavigationEvent( NavigationEvent.RETURN ) );
		}
		public function onClickAngelStreet( event:MouseEvent ):void {
			var url:String="http://angelstreetv2.blogspot.com/";
			var request:URLRequest=new URLRequest(url);
			try {
				navigateToURL(request, '_blank');// second argument is target
			} catch (e:Error) {
				trace("Error occurred!");
			}
		}
	}
}