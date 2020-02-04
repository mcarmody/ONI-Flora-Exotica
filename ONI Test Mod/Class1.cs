using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Harmony;

namespace ONI_Test_Mod
{
    [HarmonyPatch(typeof(GeneratedBuildings), "LoadGeneratedBuildings")]
    internal class HelloWorld_GeneratedBuildings_LoadGeneratedBuildings
    {
        private static void Postfix()
        {
            Debug.Log("Hello, world!");
        }
    }
}
