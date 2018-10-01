using Rollbar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
           

            //throw new Exception("Generate unhandled exception");
        }

        private void Generate_Uncaught(object sender, EventArgs e)
        {
            throw new Exception("Null pointor exception");

        }
        private void Generate_Caught_Exception(object sender, EventArgs e)
        {
            string value = null;
            try
            {
                if (value.Length == 0) // <-- Causes exception
                {
                    Console.WriteLine(value); // <-- Never reached
                }
            }
            catch (Exception e1)
            {
                RollbarLocator.RollbarInstance.Error(e1);
            }
        }
    }
}
