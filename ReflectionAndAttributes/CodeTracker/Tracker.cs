﻿using System;
using System.Linq;
using System.Reflection;

public class Tracker
{
    public void PrintMethodsByAuthor()
    {
        var type = typeof(StartUp);
        var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

        foreach (MethodInfo method in methods)
        {
            if (method.CustomAttributes.Any(n => n.AttributeType == typeof(AuthorAttribute)))
            {
                var attributes = method.GetCustomAttributes(false);

                foreach (AuthorAttribute attribute in attributes)
                {
                    Console.WriteLine($"{method.Name} is written by {attribute.Name}");
                }
            }
        }
    }
}

