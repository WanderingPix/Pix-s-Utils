using UnityEngine;
using HarmonyLib;
using BepInEx;
using ColorfulBubbles;

namespace ColorfulBubbles
{
    [HarmonyPatch(typeof(ChatBubble), nameof(ChatBubble.SetText))]
    class ColorBubble
    {
        public static void Postfix(ChatBubble __instance)
        {
            foreach (var player in PlayerControl.AllPlayerControls)
            {
                if (player.Data == __instance.playerInfo && !player.Data.IsDead)
                {
                    __instance.Background.color = player.Data.Color;
                    if (player.Data.Color == new Color(0f, 0f, 0f, 1f))
                    {
                        __instance.Background.color = new Color(1f, 1f, 1f, 1f);
                    }
                }
            }
        }
    }
}