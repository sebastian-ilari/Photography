using Photography.Models;
using Photography.Models.Enums;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace Photography.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<PhotographyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(PhotographyContext context)
        {
            context.Categories.AddOrUpdate<Category>(category => category.Name,
                new Category
                {
                    Id = 1,
                    Name = "Home",
                    DisplayType = DisplayType.Home,
                    Position = 1,
                    Visible = true,
                    Pictures = new List<Picture> 
                    {
                        new Picture
                        {
                            Id = 1,
                            CategoryId = 1,
                            FileName = "back-01.jpg",
                            PictureType = PictureType.Background,
                            Width = 1000,
                            Height = 560,
                        },
                        new Picture
                        {
                            Id = 2,
                            CategoryId = 1,
                            FileName = "back-02.jpg",
                            PictureType = PictureType.Background,
                            Width = 1000,
                            Height = 560,
                        },
                        new Picture
                        {
                            Id = 3,
                            CategoryId = 1,
                            FileName = "back-03.jpg",
                            PictureType = PictureType.Background,
                            Width = 1000,
                            Height = 560,
                        },
                        new Picture
                        {
                            Id = 4,
                            CategoryId = 1,
                            FileName = "back-04.jpg",
                            PictureType = PictureType.Background,
                            Width = 1000,
                            Height = 560,
                        },
                        new Picture
                        {
                            Id = 5,
                            CategoryId = 1,
                            FileName = "back-05.jpg",
                            PictureType = PictureType.Background,
                            Width = 1000,
                            Height = 560,
                        },
                        new Picture
                        {
                            Id = 6,
                            CategoryId = 1,
                            FileName = "back-06.jpg",
                            PictureType = PictureType.Background,
                            Width = 1000,
                            Height = 560,
                        },
                        new Picture
                        {
                            Id = 7,
                            CategoryId = 1,
                            FileName = "back-07.jpg",
                            PictureType = PictureType.Background,
                            Width = 1000,
                            Height = 560,
                        },
                        new Picture
                        {
                            Id = 8,
                            CategoryId = 1,
                            FileName = "back-08.jpg",
                            PictureType = PictureType.Background,
                            Width = 1000,
                            Height = 560,
                        },
                    },
                },

                new Category
                {
                    Id = 2,
                    Name = "About",
                    DisplayType = DisplayType.About,
                    Position = 2,
                    Visible = true,
                    Pictures = new List<Picture> 
                    {
                        new Picture
                        {
                            Id = 9,
                            CategoryId = 2,
                            FileName = "back-07.jpg",
                            PictureType = PictureType.Background,
                            Width = 1000,
                            Height = 560,
                        },
                    },
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                },

                new Category
                {
                    Id = 3,
                    Name = "Landscape",
                    DisplayType = DisplayType.Detail,
                    Position = 3,
                    Visible = true,
                    Pictures = new List<Picture> 
                    {
                        new Picture
                        {
                            Id = 10,
                            CategoryId = 3,
                            FileName = "cover-01.jpg",
                            PictureType = PictureType.Cover,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 11,
                            CategoryId = 3,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 12,
                            CategoryId = 3,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 468,
                        },
                        new Picture
                        {
                            Id = 13,
                            CategoryId = 3,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 14,
                            CategoryId = 3,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 468,
                        },
                        new Picture
                        {
                            Id = 15,
                            CategoryId = 3,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 16,
                            CategoryId = 3,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 468,
                        },
                        new Picture
                        {
                            Id = 17,
                            CategoryId = 3,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 18,
                            CategoryId = 3,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 468,
                        },
                        new Picture
                        {
                            Id = 19,
                            CategoryId = 3,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 20,
                            CategoryId = 3,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 468,
                        },
                        new Picture
                        {
                            Id = 21,
                            CategoryId = 3,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 22,
                            CategoryId = 3,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 468,
                        },
                    },
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                },

                new Category
                {
                    Id = 4,
                    Name = "Nature",
                    DisplayType = DisplayType.Detail,
                    Position = 4,
                    Visible = true,
                    Pictures = new List<Picture> 
                    {
                        new Picture
                        {
                            Id = 23,
                            CategoryId = 4,
                            FileName = "cover-01.jpg",
                            PictureType = PictureType.Cover,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 24,
                            CategoryId = 4,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 25,
                            CategoryId = 4,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 468,
                        },
                    },
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                },

                new Category
                {
                    Id = 5,
                    Name = "Architecture",
                    DisplayType = DisplayType.Detail,
                    Position = 5,
                    Visible = true,
                    Pictures = new List<Picture> 
                    {
                        new Picture
                        {
                            Id = 26,
                            CategoryId = 5,
                            FileName = "cover-01.jpg",
                            PictureType = PictureType.Cover,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 27,
                            CategoryId = 5,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 28,
                            CategoryId = 5,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 468,
                        },
                    },
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                },

                new Category
                {
                    Id = 6,
                    Name = "Portraits",
                    DisplayType = DisplayType.Detail,
                    Position = 6,
                    Visible = true,
                    Pictures = new List<Picture> 
                    {
                        new Picture
                        {
                            Id = 29,
                            CategoryId = 6,
                            FileName = "cover-01.jpg",
                            PictureType = PictureType.Cover,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 30,
                            CategoryId = 6,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 478,
                        },
                        new Picture
                        {
                            Id = 31,
                            CategoryId = 6,
                            FileName = "thumb-01.jpg",
                            PictureType = PictureType.Thumbnail,
                            Width = 383,
                            Height = 468,
                        },
                    },
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.",
                },

                new Category
                {
                    Id = 7,
                    Name = "Contact",
                    DisplayType = DisplayType.Contact,
                    Position = 7,
                    Visible = true,
                    Pictures = new List<Picture> 
                    {
                        new Picture
                        {
                            Id = 32,
                            CategoryId = 7,
                            FileName = "contact.jpg",
                            PictureType = PictureType.Cover,
                            Width = 374,
                            Height = 560,
                        },
                    },
                });
        }
    }
}