using DesignPartterns.FactoryMethod.ConcreteProdouct;
using DesignPartterns.FactoryMethod.AbstractCreator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPartterns.FactoryMethod.ConcreteCreator
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class Resume : Document
    {
        // Factory Method implementation
        public override void CreatePages()
        {
            Pages.Add(new SkillsPage());
            Pages.Add(new EducationPage());
            Pages.Add(new ExperiencePage());
        }
    }
}
