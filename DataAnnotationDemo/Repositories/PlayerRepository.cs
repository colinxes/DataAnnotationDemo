using System;
using System.Collections.Generic;
using DataAnnotationDemo.Enums;
using DataAnnotationDemo.Models;
using DataAnnotationDemo.Properties;

namespace DataAnnotationDemo.Repositories
{
    public class PlayerRepository
    {
        private static PlayerRepository _instance;
        public static PlayerRepository Instance => _instance ?? new PlayerRepository();

        private PlayerRepository(){}

        public IEnumerable<Player> GetAllUsers()
        {
            List<Player> users = new List<Player>
                {
                    new Player()
                    {
                        Id = 1,
                        Profilepicture = Resources.Reus,
                        BirthDate = new DateTime(2000, 02, 14), 
                        Email = "reus@lit.de", 
                        Password = "Test",
                        Forname = "Marco", 
                        LastName = "Reus", 
                        PlayerPosition = (int)enmPlayerPositions.Striker
                    },
                    new Player()
                    {
                        Id = 2,
                        Profilepicture = Resources.Mueller,
                        BirthDate = new DateTime(1995, 06, 14), 
                        Email = "müller@lit.de", 
                        Password = "Test",
                        Forname = "Thomas", 
                        LastName = "Müller", 
                        PlayerPosition = (int)enmPlayerPositions.Striker
                    },
                    new Player()
                    {
                        Id = 3,
                        Profilepicture = Resources.Podolski,
                        BirthDate = new DateTime(1962, 12, 24), 
                        Email = "podolski@lit.de", 
                        Password = "Test",
                        Forname = "Lukas", 
                        LastName = "Podolski", 
                        PlayerPosition = (int)enmPlayerPositions.Striker
                    },
                    new Player()
                    {
                        Id = 4,
                        BirthDate = new DateTime(1970, 06, 4), 
                        Email = "neuer@lit.de", 
                        Password = "Test",
                        Forname = "Manuel", 
                        LastName = "Neuer", 
                        PlayerPosition = (int)enmPlayerPositions.Goalkeeper
                    },
                    new Player()
                    {
                        Id = 5,
                        BirthDate = new DateTime(2000, 04, 3), 
                        Email = "kroos@lit.de", 
                        Password = "Test",
                        Forname = "Toni", 
                        LastName = "Kroos", 
                        PlayerPosition = (int)enmPlayerPositions.Midfield
                    }
                };

                return users;
        }

    }
}