using System.Reflection;
using UnityEngine;

public class ReflectionExample
{
    static public void InvokeBoinkByReflection()
    {
        typeof(ReflectionExample).GetMethod("Boink", BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, null);
    }

    // No other code directly references the Boink method, so when when stripping is enabled,
    // it will be removed unless the [Preserve] attribute is applied.
    static void Boink()
    {
        Debug.Log("##################### Boink");
    }
}
