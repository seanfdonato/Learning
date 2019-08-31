﻿using DesignPartterns.FactoryMethod.AbstractProduct;
using DesignPartterns.FactoryMethod.ConcreteCreator;
using DesignPartterns.FactoryMethod.AbstractCreator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.FactoryMethod
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Factory Method Design Pattern.
    /// </summary>
    public static class FactoryMethodStartup
    {
        public static void Start()
        {
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Wait for user
            Console.ReadKey();
        }

    }
}
