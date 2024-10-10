using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Models;

namespace MovieApp.Views;

public partial class AddPage : ContentPage
{
    public AddPage()
    {
        InitializeComponent();
    }

    private void Save_OnClicked(object sender, EventArgs e)
    {
        var movie = new Movie();
        movie.Title = txtTitle.Text;
        movie.Rating = txtRating.Text;
        App.MovieList.Add(movie);


        txtTitle.Text = String.Empty;
        txtRating.Text = String.Empty;
    }
}