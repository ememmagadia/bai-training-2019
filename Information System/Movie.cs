using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace Information_System
{
	class Movie
	{
		public string Title { get; set; }
		public string Country { get; set; }
		public string Year { get; set; }
		public string LeadActor { get; set; }
		public string Genre { get; set; }

		public Movie(string title = "No Title", string country = "No Country", string year = "1990", string leadactor = "No Actor", string genre = "Comedy")
		{
			Title = title;
			Country = country;
			Year = year;
			LeadActor = leadactor;
			Genre = genre;
		}

		public void toViewAll(ArrayList movieList)
		{
			var movielist = movieList.OfType<Movie>();
			foreach (var movie in movielist)
			{
				Console.WriteLine("Title : {0}\nCountry : {1}\nYear : {2}\nLead Actor : {3}\nGenre : {4}\n", movie.Title, movie.Country, movie.Year, movie.LeadActor, movie.Genre);
			}
			Console.ReadKey();
		}
		public void toView(ArrayList movieList, string item, string choice)
		{
			var movieListenum = movieList.OfType<Movie>();
			switch (choice)
			{
				case "A":
					var result = from movie in movieListenum where movie.Title == item select movie;
					foreach (var movie in result)
					{
						Console.WriteLine("Title : {0}\nCountry : {1}\nYear : {2}\nLead Actor : {3}\nGenre : {4}\n", movie.Title, movie.Country, movie.Year, movie.LeadActor, movie.Genre);
					}
					Console.ReadKey();
					break;
				case "B":
					result = from movie in movieListenum where movie.Year == item select movie;
					foreach (var movie in result)
					{
						Console.WriteLine("Title : {0}\nCountry : {1}\nYear : {2}\nLead Actor : {3}\nGenre : {4}\n", movie.Title, movie.Country, movie.Year, movie.LeadActor, movie.Genre);
					}
					Console.ReadKey();
					break;
				case "C":
					result = from movie in movieListenum where movie.Genre == item select movie;
					foreach (var movie in result)
					{
						Console.WriteLine("Title : {0}\nCountry : {1}\nYear : {2}\nLead Actor : {3}\nGenre : {4}\n", movie.Title, movie.Country, movie.Year, movie.LeadActor, movie.Genre);
					}
					Console.ReadKey();
					break;
			}


		}
	}
}
