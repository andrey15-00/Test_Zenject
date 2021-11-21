using Zenject;
using UnityEngine;
using System.Collections;
using System;

namespace UnityGame
{
    public static class LogWrapper
    {
        public static void Log(string message)
        {
            Debug.Log(message);
        }
    }
}