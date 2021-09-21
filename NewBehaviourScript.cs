using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

namespace Test
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            typeof(ReflectionExample).GetMethod("Boink", BindingFlags.NonPublic | BindingFlags.Static).Invoke(null, null);

            ReflectionExample t = new ReflectionExample();
            
            Debug.Log(t.boing);
            Debug.Log(t.boing2);
        }
    }
}
