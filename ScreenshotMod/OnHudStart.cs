using System;
using HarmonyLib;
using UnityEngine;
using System.Linq;

namespace SayCheese
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Start))]
    public class OnHudStart
    {
        public static void Postfix(HudManager __instance)
        {
            __instance.gameObject.AddComponent<ScreenshotComp>();
        }
    }
}
