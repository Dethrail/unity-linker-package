﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test
{
    public class NewBehaviourScript : MonoBehaviour
    {
        void Start()
        {
            ReflectionExample.InvokeBoinkByReflection();
        }
    }

}
