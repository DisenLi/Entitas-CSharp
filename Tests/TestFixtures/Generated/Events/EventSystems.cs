//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class EventSystems : Feature {

    public EventSystems(Contexts contexts) {
        Add(new TestEventToGenerateEventSystem(contexts)); // priority: 0
        Add(new Test2EventToGenerateEventSystem(contexts)); // priority: 0
        Add(new TestFlagEventEventSystem(contexts)); // priority: 0
        Add(new TestStandardEventEventSystem(contexts)); // priority: 0
        Add(new TestFlagEntityEventEventSystem(contexts)); // priority: 1
        Add(new TestStandardEntityEventEventSystem(contexts)); // priority: 1
    }
}