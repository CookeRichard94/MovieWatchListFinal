<b>Design Document</b>
==========================================

Name: Richard Cooke

Student ID: G00331787

E-mail: G00331787@gmit.ie

INTRODUCTION
==============================

For my 3rd year Mobile Applications Development project we have been assigned to create a cross-platform application using visual studios, the C# programming language and UWP technologies. For this purpose, I have created an application that acts as a movie database that contains a watchlist for the user. The application was intended to have a similar design to the IMDB.com website. The cross-platforming aspect of this application should allow it to be played on Windows & Android platforms.

To Acquire the application, open the command prompt and enter the command ‘Git Clone https://github.com/CookeRichard94/MovieWatchListFinal ‘.
From here open Visual Studio 2017, selecting open project/solution and selecting the solution downloaded from github.
After this the application is most easily run by selecting the UWP launch and selecting start.


DESIGN
==================================

The Main Page design for the application is a tabbed page. This page contains two children, content pages called ‘ListPage’ and ‘WatchPage’, that the user can navigate to by selecting either of the tabs generated at the top of the page.

The ListPage contains a 3*2 grid which contains all of the contents displayed on the page.
First implemented on the page is a background logo of a film reel, that immediately establishes the nature of the application. 
On the far left of the page is a list view that contains 100 movies, the data from which has been bound from a JSON file.
All of the items in this list view display three values, the title of the movie, the year it was released and the director of the movie. The list view allows for the user to scroll through each of the movies on the database.
In the centre of the page, overlaying the film reel logo, is a stacklayout which contains all of the values attributed to each movie
in the JSON file. If the user selects any of the items in the list view then a method is called and returns the full details of the movie in the central panel using data binding. 
At the bottom of the page are two buttons a save button and an ‘addToWatchList’ button.
If the user right clicks on any item then a delete option will reveal itself and if left-clicked then the item selected will be deleted from the listview, if the user click the save button after this then the item should be permanently removed.
In the central panel, every value bar the title of the movie has an entry box beside it, these are in place if the user feels any of the information is incorrect, if the user enters new information in the entry boxes and presses the save button then the list is refreshed and the item will now have its updated values stored.
The buttons and listview for the page have also been stylized.

The WatchPage contains a similar design to the Listpage although it draws it’s data from a different JSON file.
One item is pre-stored in the watch page that the user can manipulate to update as their next in line to watch movie.
The list view in the WatchPage also contains the delete option.

Issues
====================================
-	Issue pushing and pulling from git repository. When repository was cloned and opened in visual studio each item had a red ‘x’ beside them, which contained the caption ‘pending delete’. When attempting to make new commits to the repository a delete node is mentioned beside each file. If the commit is followed through with then the push will delete all files and items in the repository.
-	Multiple restarts of project and new repositories made due to issues with Xamarin throwing errors despite continued rebuild and redeploys.

Failed Implementations
=========================================

-	Add function. This would have been applied to the addToWatchList button on the ListPage. The purpose of this function would have been to retrieve all of the details displayed in the central panel for the selected movie and created a new object using the movie.cs contstructor that would then convert and append the selected movie to the watch.txt JSON file, so that it would be displayed on the WatchPage. The code intended to be used aused run time errors and was thus removed.

TEST CASES
===================================================


<b>Test Case #1 – Data Binding</b>

Append a new movie item to movies.txt, title = the incredibles, year = 2004, description = , runtime = , country = , imdbrating = , starring = , director = Brad Bird, boxoffice = 

Run Application.

Expected Result = Three values for The Incredibles displayed in list view.

Actual Result = Three values for The Incredibles displayed in list view.

</br>

<b>Test Case #2 – Updating</b>

Run Application

Select The Incredibles from listview.

Enter into field description ‘A family of undercover superheroes, while trying to live the quiet suburban life, are forced into action to save the world.’

Click save button 

Close the application

Run the application

Expected Result = Description value added as described

Actual Result = Description value added as described

</br>

<b>Test Case #3 – Deleting</b>

Run Application

Right click on The Incredibles item

Click delete

Click the save button

Close the application

Run the application

Expected result = The Incredibles item no longer on listview

Actual result = The increibles item no longer on listview
