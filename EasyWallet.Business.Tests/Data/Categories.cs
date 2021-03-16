﻿using EasyWallet.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyWallet.Business.Tests.Data
{
    public class Categories
    {
        public static List<CategoryData> ActiveCategoriesWithTags = new List<CategoryData>()
        {
            new CategoryData()
            {
                Id = 1,
                UserId = 1,
                CategoryTypeId = 2,
                Name = "Incomes",
                Tags = new List<TagData>()
                {
                    new TagData()
                    {
                        Id = 1,
                        CategoryId = 1,
                        Name = "Incomes",
                        CreatedAt = new DateTime(2020, 1, 1)
                    }
                },
                CreatedAt = new DateTime(2020, 1, 1)
            },
            new CategoryData()
            {
                Id = 2,
                UserId = 1,
                CategoryTypeId = 1,
                Name = "Others",
                Tags = new List<TagData>()
                {
                    new TagData()
                    {
                        Id = 2,
                        CategoryId = 2,
                        Name = "Others",
                        CreatedAt = new DateTime(2020, 1, 1)
                    },
                    new TagData()
                    {
                        Id = 5,
                        CategoryId = 2,
                        Name = "Food",
                        IsAutoGenerated = true,
                        CreatedAt = new DateTime(2020, 1, 2)
                    }
                },
                CreatedAt = new DateTime(2020, 1, 1)
            },
            new CategoryData()
            {
                Id = 3,
                UserId = 1,
                CategoryTypeId = 1,
                Name = "Bills",
                Tags = new List<TagData>()
                {
                    new TagData()
                    {
                        Id = 3,
                        CategoryId = 3,
                        Name = "Services",
                        CreatedAt = new DateTime(2020, 1, 1),
                        DeletedAt = new DateTime(2020, 1, 1)
                    },
                    new TagData()
                    {
                        Id = 4,
                        CategoryId = 3,
                        Name = "Water",
                        CreatedAt = new DateTime(2020, 1, 1)
                    }
                },
                CreatedAt = new DateTime(2020, 1, 1)
            }
        };

        public static CategoryData CategoryWithDeletedAndAutogeneratedTags = new CategoryData()
        {
            Id = 1,
            UserId = 1,
            CategoryTypeId = 1,
            Name = "Others",
            Tags = new List<TagData>()
                {
                    new TagData()
                    {
                        Id = 1,
                        CategoryId = 1,
                        Name = "Others",
                        CreatedAt = new DateTime(2020, 1, 1)
                    },
                    new TagData()
                    {
                        Id = 2,
                        CategoryId = 1,
                        Name = "Food",
                        IsAutoGenerated = true,
                        CreatedAt = new DateTime(2020, 1, 2)
                    },
                    new TagData()
                    {
                        Id = 3,
                        CategoryId = 1,
                        Name = "Other",
                        CreatedAt = new DateTime(2020, 1, 2),
                        DeletedAt = new DateTime(2020, 1, 2)
                    }
                },
            CreatedAt = new DateTime(2020, 1, 1)
        };
    }
}
