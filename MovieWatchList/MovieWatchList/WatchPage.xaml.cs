using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Utils;

namespace MovieWatchList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WatchPage : ContentPage
    {
        List<Movie> movieList;
        public WatchPage()
        {
            InitializeComponent();
            SetDefaultStuffMethod();
        }

        private void SetDefaultStuffMethod()
        {
            if (movieList == null) movieList = new List<Movie>();

            movieList = MyUtils.ReadWatchListData();
            // set the data context for the list view
            lvMovies.ItemsSource = movieList;
        }

        private void lvMovie_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void btnSaveFile_Clicked(object sender, EventArgs e)
        {
            // save the list of dogs to the local application folder
            MyUtils.SaveMovieListData(movieList);
        }
    }
}