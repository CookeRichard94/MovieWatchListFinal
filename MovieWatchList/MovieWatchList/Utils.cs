using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using MovieWatchList;
using Newtonsoft.Json;

namespace Utils
{
    class MyUtils
    {
        public const string JSON_MOVIE_FILE = "Movies.txt";
        public const string JSON_WATCH_FILE = "Watch.txt";

        //reads data from json file movies.txt
        public static List<Movie> ReadMovieListData()
        {
            List<Movie> myList = new List<Movie>();
            string jsonText;

            try  // reading the localApplicationFolder first
            {
                string path = Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData);
                string filename = Path.Combine(path, JSON_MOVIE_FILE);
                using (var reader = new StreamReader(filename))
                {
                    jsonText = reader.ReadToEnd();
                    // need json library
                }
            }
            catch // fallback is to read the default file
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(
                                                typeof(MainPage)).Assembly;
                // create the stream
                Stream stream = assembly.GetManifestResourceStream(
                                    "MovieWatchList.Data.Movies.txt");
                using (var reader = new StreamReader(stream))
                {
                    jsonText = reader.ReadToEnd();
                    // include JSON library now
                }
            }

            myList = JsonConvert.DeserializeObject<List<Movie>>(jsonText);

            return myList;
        }

        //reads the json data from watch.txt
        public static List<Movie> ReadWatchListData()
        {
            List<Movie> myList = new List<Movie>();
            string jsonText;

            try  // reading the localApplicationFolder first
            {
                string path = Environment.GetFolderPath(
                                Environment.SpecialFolder.LocalApplicationData);
                string filename = Path.Combine(path, JSON_WATCH_FILE);
                using (var reader = new StreamReader(filename))
                {
                    jsonText = reader.ReadToEnd();
                    // need json library
                }
            }
            catch // fallback is to read the default file
            {
                var assembly = IntrospectionExtensions.GetTypeInfo(
                                                typeof(MainPage)).Assembly;
                // create the stream
                Stream stream = assembly.GetManifestResourceStream(
                                    "MovieWatchList.Data.Watch.txt");
                using (var reader = new StreamReader(stream))
                {
                    jsonText = reader.ReadToEnd();
                    // include JSON library now
                }
            }

            myList = JsonConvert.DeserializeObject<List<Movie>>(jsonText);

            return myList;
        }

        //saves data to movies.txt
        public static void SaveMovieListData(List<Movie> saveList)
        {
            // need the path to the file
            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);
            string filename = Path.Combine(path, JSON_MOVIE_FILE);
            // use a stream writer to write the list
            using (var writer = new StreamWriter(filename, false))
            {
                // stringify equivalent
                string jsonText = JsonConvert.SerializeObject(saveList);
                writer.WriteLine(jsonText);
            }
        }

        //Saves data to watch.txt
        public static void SaveMovieListData2(List<Movie> saveList)
        {
            // need the path to the file
            string path = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);
            string filename = Path.Combine(path, JSON_WATCH_FILE);
            // use a stream writer to write the list
            using (var writer = new StreamWriter(filename, false))
            {
                // stringify equivalent
                string jsonText = JsonConvert.SerializeObject(saveList);
                writer.WriteLine(jsonText);
            }
        }
    }
}
