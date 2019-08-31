﻿using DesignPartterns.FactoryMethod.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.FactoryMethod.AbstractCreator
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>

    abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }

        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method
        public abstract void CreatePages();
    }
}
