using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Utils;
using Newtonsoft.Json;

namespace MovieWatchList
{
    public partial class MainPage : TabbedPage
    {


        public MainPage()
        {
            InitializeComponent();
            this.CurrentPage = this.Children[0];
        }

        
    }
}
