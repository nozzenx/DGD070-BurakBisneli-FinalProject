//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly ECS.Components.PlayerHealedComponent eCSComponentsPlayerHealedComponent = new ECS.Components.PlayerHealedComponent();

    public bool isECSComponentsPlayerHealed {
        get { return HasComponent(GameComponentsLookup.ECSComponentsPlayerHealed); }
        set {
            if (value != isECSComponentsPlayerHealed) {
                var index = GameComponentsLookup.ECSComponentsPlayerHealed;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : eCSComponentsPlayerHealedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherECSComponentsPlayerHealed;

    public static Entitas.IMatcher<GameEntity> ECSComponentsPlayerHealed {
        get {
            if (_matcherECSComponentsPlayerHealed == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ECSComponentsPlayerHealed);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherECSComponentsPlayerHealed = matcher;
            }

            return _matcherECSComponentsPlayerHealed;
        }
    }
}
