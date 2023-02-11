﻿using eTickets.Domains.Models;

namespace eTickets.Seed.Storage
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
                    },new Cinema()
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

            }
            else if (typeof(T).Equals(typeof(Producer)))
            {

            }
            else if (typeof(T).Equals(typeof(Movie)))
            {

            }
            else if (typeof(T).Equals(typeof(ActorMovie)))
            {

            }
            return new Exception("Invalid type");
        }
    }
}