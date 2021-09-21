using System.Reflection;
using UnityEngine;

namespace Test
{
    public class ReflectionExample
    {
        public string boing = "Boink";
        public string boing2 = "Boink2";

        // No other code directly references the Boink method, so when when stripping is enabled,
        // it will be removed unless the [Preserve] attribute is applied.
        static void Boink()
        {
            Debug.Log("##################### Boink");
        }
    }

}
