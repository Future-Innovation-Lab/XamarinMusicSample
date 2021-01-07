using MediaManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MediaManagerDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CrossMediaManager.Current.Play("https://file-examples-com.github.io/uploads/2017/11/file_example_MP3_700KB.mp3");
        }
    }
}
