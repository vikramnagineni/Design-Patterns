﻿using System;

namespace Design_Patterns.DecoratorPattern.Day3
{
    public class Textbox : IComponent
    {
        public void Draw()
        {
            Console.WriteLine("Draw textbox");
        }

        public string GetDescription()
        {
            return "This is textbox description";
        }
    }
}
