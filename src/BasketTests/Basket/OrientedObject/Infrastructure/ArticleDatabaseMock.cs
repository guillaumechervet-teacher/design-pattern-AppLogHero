﻿using System;

namespace Basket.OrientedObject.Infrastructure
{
    public class ArticleDatabaseMock
    {
        public ArticleDatabase GetArticle(string id)
        {
            switch (id)
            {
                case "1":
                    return new ArticleDatabase {Id = "1", Price = 1, Stock = 35, Label = "banana", Category = "food"};
                case "2":
                    return new ArticleDatabase
                    {
                        Id = "1",
                        Price = 500,
                        Stock = 20,
                        Label = "frigo",
                        Category = "electronic"
                    };
                case "3":
                    return new ArticleDatabase
                    {
                        Id = "1",
                        Price = 1,
                        Stock = 68,
                        Label = "chaise",
                        Category = "desktop"
                    };
                default:
                    throw new NotImplementedException();

            }
        }

    }
}