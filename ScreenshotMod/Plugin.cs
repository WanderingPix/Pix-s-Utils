using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Reactor;
using Reactor.Utilities;
using Il2CppInterop.Runtime.Injection;

namespace SayCheese;

[BepInAutoPlugin]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
public partial class TemplatePlugin : BasePlugin
{
    public Harmony Harmony { get; } = new(Id);
    public override void Load()
    {
         Harmomy.PatchAll();
         ClassInjector.RegisterTypeInIl2Cpp<FrozenBody>();

    }
}
    
