﻿var CurrentMovieViewModel = function () {
    var self = this;
    self.Id = ko.observable();
    self.Title = ko.observable();
    self.MainCategory = ko.observable();
    self.PictureUrl = ko.observable();
    self.Rating = ko.observable();
    self.Tags = ko.observableArray();
    self.Actors = ko.observableArray();

    self.init = function (id, title, pictureUrl, rating, tags, actors, categoryName) {
        self.Id(id);
        self.Title(title);
        self.PictureUrl(pictureUrl);
        self.Rating(rating);
        self.MainCategory(categoryName);
        self.Tags(tags);
        self.Actors(actors);
    }
}


var MovieDetailsViewModel = function () {
    var self = this;
    self.FetchedMovie = ko.observable();

    self.init = function (data) {
        var currentMovie = new CurrentMovieViewModel();
        currentMovie.init(data[0].id, data[0].title, data[0].pictureUrl, data[0].rating, data[0].tags, data[0].actors, data[0].categoryName)
        self.FetchedMovie(currentMovie);
    }
}
