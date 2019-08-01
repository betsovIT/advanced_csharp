using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


public class Spy
{
    public string StealFieldInfo(string classToInvestigate, params string[] args)
    {
        Type classType = Type.GetType(classToInvestigate);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        var sb = new StringBuilder();

        Object hacker = Activator.CreateInstance(classType, new object[] { });

        sb.AppendLine($"Class under investigation: {classToInvestigate}");


        foreach (FieldInfo field in classFields.Where(f => args.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(hacker)}");
        }

        return sb.ToString().TrimEnd();

    }
}

