// See https://aka.ms/new-console-template for more information

using DiContainer;

Console.WriteLine("Hello, World!");


Container.Register<IFilmRepository, DummyFilmRepository>();
Container.Register<FilmController, FilmController>();

Console.ReadLine();

var controller = Container.GetInstance<FilmController>();
controller.List();

Console.ReadLine();