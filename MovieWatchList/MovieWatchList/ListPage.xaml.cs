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
	public partial class ListPage : ContentPage
	{
        List<Movie> movieList;
        public ListPage ()
		{
			InitializeComponent ();
            SetDefaultStuffMethod();
        }

        private void SetDefaultStuffMethod()
        {
            if (movieList == null) movieList = new List<Movie>();

            movieList = MyUtils.ReadMovieListData();
            // set the data context for the list view
            lvMovies.ItemsSource = movieList;
        }

        private void lvMovie_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            slOneElement.BindingContext = (Movie)e.SelectedItem;
        }

        private void btnSaveFile_Clicked(object sender, EventArgs e)
        {
            // save the list of dogs to the local application folder
            MyUtils.SaveMovieListData(movieList);

            RefreshListView();
        }

        private void WatchListButton_Clicked(object sender, EventArgs e)
        {
            //Code to add the json data from movies.txt to watch.txt
        }

        private void RefreshListView()
        {
            lvMovies.ItemsSource = null;
            lvMovies.ItemsSource = movieList;
        }

        private void DeleteContext_Clicked(object sender,
                                           EventArgs e)
        {
            // really nice to get the object that was clicked.
            Movie movie = (sender as MenuItem).CommandParameter as Movie;
            movieList.Remove(movie);
            //< MenuItem

            RefreshListView();
        }

       
    }
}