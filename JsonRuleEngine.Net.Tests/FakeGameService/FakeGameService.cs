using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace JsonRuleEngine.Net.Tests
{

    public static class FakeGameService
    {
        public static IQueryable<Game> GetDatas()
        {
            return new List<Game>()
            {
                new Game()
                {
                    Name= "Assassin's creed",
                    Price = 45.3,
                    Category = "Adventure",
                    BoolValue = true,
                    Date =new DateTime(2021,1,1),
                    Type = GameType.RPG,
                    Editor = new Editor()
                    {
                        Id = 1,
                        Name= "Ubisoft"
                    },
                    Reviews = new List<Review>()
                    {
                       new Review()
                       {
                           Id = 1,
                           Text ="It's cool",
                           Author = new Author()
                           {
                               Name = "Johnny"
                           },
                       },
                       new Review()
                       {
                           Id = 2,
                           Text ="It's very cool"
                       }
                    }
                },
                 new Game()
                {
                    Name= "Destiny",
                    Type = GameType.RPG,
                    Price = 23.3,
                    Date =new DateTime(2021,1,12),
                    Reviews = new List<Review>{}
                },
                 new Game()
                {
                    Name= "The forest",
                    Type = GameType.RPG,
                    Price = 22,
                    Date =new DateTime(2021,1,11),
                    Reviews = new List<Review>{}
                },
                 new Game()
                {
                    Name= "Sim City",
                    Type = GameType.CityBuilder,
                    Price = 13,
                    Date =new DateTime(2021,1,2),
                    Reviews = new List<Review>{}
                },
                 new Game()
                {
                    Name= "GTA V",
                    Type = GameType.Action,
                    Price = 77,
                    Date =new DateTime(2022,1,1),
                    Editor = new Editor()
                    {
                        Id = 2,
                        Name= "test"
                    },
                    Reviews = new List<Review>()
                    {
                       new Review()
                       {
                           Id = 2,
                           Author = new Author()
                           {
                               Name = "Johnny"
                           },
                           Text ="It's cool"
                       }
                    }
                },
                 new Game()
                {
                    Name= "GTA IV",
                    Type = GameType.Action,
                    Price = 24,
                    Date =new DateTime(2018,1,1),
                    Editor = new Editor()
                    {
                        Id = 1,
                        Name= "test"
                    },
                    Reviews = new List<Review>{}
                }
            }.AsQueryable();
        }
    }
}
