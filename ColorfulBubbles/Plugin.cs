using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Reactor;
using Reactor.Networking;
using Reactor.Networking.Attributes;
using Reactor;
using Reactor.Utilities;

namespace ColorfulBubbles;

[BepInAutoPlugin("ColorfulBubbles", "ColorfulBubbles")]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
[BepInDependency("com.slushiegoose.townofus", BepInDependency.DependencyFlags.SoftDependency)]
public partial class CBPlugin : BasePlugin
{
    public Harmony Harmony { get; } = new(Id);
    public ConfigFile GetConfigFile() => Config;
    public override void Load()
    {
        Harmony.PatchAll();
    }
    
}
