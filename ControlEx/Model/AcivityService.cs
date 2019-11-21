using System;
using System.Collections.Generic;
using System.Text;

namespace ControlEx.Model
{
    class AcivityService
    {
        public IList<Users> GetUsers()
        {
            return new List<Users>
            {
                new Users
                {
                    UserID = 1,
                    UserName = "SanazZ",
                    Description = "SanazZ sent a photo posted by @brookeisep",
                    //Image
                },
                new Users
                {
                    UserID = 2,
                    UserName = "ILove",
                    Description = "ILove started following you",
                    //Image
                },
                new Users
                {
                    UserID = 3,
                    UserName = "Alex B",
                    Description = "Your Facebook friend Alex B is on Instagram",
                    //Image
                },
                new Users
                {
                    UserID = 4,
                    UserName = "Rody Rana",
                    Description = "Your Facebook friend Rody Rana is on Instagram",
                    //Image
                },
                new Users
                {
                    UserID = 5,
                    UserName = "Betty",
                    Description = "Your Facebook friend Betty is on Instagram",
                    //Image
                },
                new Users
                {
                    UserID = 6,
                    UserName = "Christy",
                    Description = "Your Facebook friend Christy is on Instagram",
                    //Image
                },
                new Users
                {
                    UserID = 7,
                    UserName = "Pratt",
                    Description = "Pratt started following you",
                    //Image
                },
                new Users
                {
                    UserID = 8,
                    UserName = "Martin",
                    Description = "Martin liked your photo",
                    //Image
                },
                new Users
                {
                    UserID = 9,
                    UserName = "Rosy Max",
                    Description = "Your Facebook friend Rosy Max is on Instagram",
                    //Image
                },
                new Users
                {
                    UserID = 10,
                    UserName = "Ruby Soho",
                    Description = "Ruby Ruby Ruby Soho",
                    //Image
                },
            };
        }
    
    }
}
