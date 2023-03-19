using eTickets.Domains.Models;
using eTickets.Domains.Models.Enums;

namespace eTickets.SeedStorage.InitialData
{
    public static class Storage
    {
        public static dynamic Seed<T>() where T : class
        {
            if (typeof(T).Equals(typeof(Cinema)))
            {
                return new List<Cinema>()
                {
                    new Cinema()
                    {
                        Logo = "",
                        Name = "Cinema 1",
                        Description = "Description of the Cinema 1"
                    },
                    new Cinema()
                    {
                        Logo = "",
                        Name = "Cinema 2",
                        Description = "Description of the Cinema 2"
                    },
                    new Cinema()
                    {
                        Logo = "",
                        Name = "Cinema 3",
                        Description = "Description of the Cinema 4"
                    },
                    new Cinema()
                    {
                        Logo = "",
                        Name = "Cinema 4",
                        Description = "Description of the Cinema 4"
                    }
                    ,new Cinema()
                    {
                        Logo = "",
                        Name = "Cinema 5",
                        Description = "Description of the Cinema 5"
                    }
                };
            }
            else if (typeof(T).Equals(typeof(Actor)))
            {
                return new List<Actor>()
                {
                   new Actor()
                   {
                       FullName = "Actror 1",
                       Bio = "This is the bio of first actor",
                       ProfilePictureURL = ""
                   },
                   new Actor()
                   {
                       FullName = "Actror 2",
                       Bio = "This is the bio of second actor",
                       ProfilePictureURL = ""
                   },
                   new Actor()
                   {
                       FullName = "Actror 3",
                       Bio = "This is the bio of third actor",
                       ProfilePictureURL = ""
                   },
                   new Actor()
                   {
                       FullName = "Actror 4",
                       Bio = "This is the bio of fourth actor",
                       ProfilePictureURL = ""
                   },
                   new Actor()
                   {
                       FullName = "Actror 5",
                       Bio = "This is the bio of fifth actor",
                       ProfilePictureURL = ""
                   }
               };
            }
            else if (typeof(T).Equals(typeof(Producer)))
            {
                return new List<Producer>()
                {
                   new Producer()
                   {
                       FullName = "Producer 1",
                       Bio = "This is the bio of first producer",
                       ProfilePictureURL = ""
                   },
                   new Producer()
                   {
                       FullName = "Producer 2",
                       Bio = "This is the bio of second producer",
                       ProfilePictureURL = ""
                   },
                   new Producer()
                   {
                       FullName = "Producer 3",
                       Bio = "This is the bio of third producer",
                       ProfilePictureURL = ""
                   },
                   new Producer()
                   {
                       FullName = "Producer 4",
                       Bio = "This is the bio of fourth producer",
                       ProfilePictureURL = ""
                   },
                   new Producer()
                   {
                       FullName = "Producer 5",
                       Bio = "This is the bio of fifth producer",
                       ProfilePictureURL = ""
                   }
                };
            }
            else if (typeof(T).Equals(typeof(Movie)))
            {
                return new List<Movie>()
                {
                    new Movie
                    {
                        Name = "Movie 1",
                        Description = "Description of first Movie",
                        Price = 39.50,
                        ImageURL = "",
                        DateStart = DateTime.Now.AddDays(-10),
                        DateEnd = DateTime.Now.AddDays(-2),
                        CinemaId = 1,
                        ProducerId = 1,
                        Genre = Genre.Action
                    },
                    new Movie
                    {
                        Name = "Movie 2",
                        Description = "Description of second Movie",
                        Price = 39.50,
                        ImageURL = "",
                        DateStart = DateTime.Now,
                        DateEnd = DateTime.Now.AddDays(12),
                        CinemaId = 2,
                        ProducerId = 2,
                        Genre = Genre.Comedy
                    },
                    new Movie
                    {
                        Name = "Movie 3",
                        Description = "Description of third Movie",
                        Price = 39.50,
                        ImageURL = "",
                        DateStart = DateTime.Now.AddDays(-10),
                        DateEnd = DateTime.Now.AddDays(2),
                        CinemaId = 3,
                        ProducerId = 3,
                        Genre = Genre.Documentary
                    },
                    new Movie
                    {
                        Name = "Movie 4",
                        Description = "Description of fourth Movie",
                        Price = 39.50,
                        ImageURL = "",
                        DateStart = DateTime.Now.AddDays(-10),
                        DateEnd = DateTime.Now.AddDays(-2),
                        CinemaId = 4,
                        ProducerId = 5,
                        Genre = Genre.Drama
                    },
                    new Movie
                    {
                        Name = "Movie 5",
                        Description = "Description of fifth Movie",
                        Price = 39.50,
                        ImageURL = "",
                        DateStart = DateTime.Now.AddDays(-1),
                        DateEnd = DateTime.Now.AddDays(11),
                        CinemaId = 5,
                        ProducerId = 5,
                        Genre = Genre.Cartoon
                    }
                };
            }
            else if (typeof(T).Equals(typeof(ActorMovie)))
            {
                return new List<ActorMovie>()
                {
                    new ActorMovie
                    {
                        ActorId = 1,
                        MovieId = 1
                    },
                    new ActorMovie
                    {
                        ActorId = 2,
                        MovieId = 2
                    },
                    new ActorMovie
                    {
                        ActorId = 3,
                        MovieId = 2
                    },
                    new ActorMovie
                    {
                        ActorId = 5,
                        MovieId = 2
                    },
                    new ActorMovie
                    {
                        ActorId = 3,
                        MovieId = 3
                    },
                    new ActorMovie
                    {
                        ActorId = 4,
                        MovieId = 4
                    },
                    new ActorMovie
                    {
                        ActorId = 5,
                        MovieId = 5
                    },
                    new ActorMovie
                    {
                        ActorId = 1,
                        MovieId = 5
                    },
                    new ActorMovie
                    {
                        ActorId = 3,
                        MovieId = 5
                    },
                    new ActorMovie
                    {
                        ActorId = 2,
                        MovieId = 5
                    }
                };
            }
            return new Exception("Invalid type");
        }
    }
}
