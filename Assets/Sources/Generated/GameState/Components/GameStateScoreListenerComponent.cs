//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateContext {

    public GameStateEntity scoreListenerEntity { get { return GetGroup(GameStateMatcher.ScoreListener).GetSingleEntity(); } }
    public ScoreListenerComponent scoreListener { get { return scoreListenerEntity.scoreListener; } }
    public bool hasScoreListener { get { return scoreListenerEntity != null; } }

    public GameStateEntity SetScoreListener(IScoreListener newValue) {
        if (hasScoreListener) {
            throw new Entitas.EntitasException("Could not set ScoreListener!\n" + this + " already has an entity with ScoreListenerComponent!",
                "You should check if the context already has a scoreListenerEntity before setting it or use context.ReplaceScoreListener().");
        }
        var entity = CreateEntity();
        entity.AddScoreListener(newValue);
        return entity;
    }

    public void ReplaceScoreListener(IScoreListener newValue) {
        var entity = scoreListenerEntity;
        if (entity == null) {
            entity = SetScoreListener(newValue);
        } else {
            entity.ReplaceScoreListener(newValue);
        }
    }

    public void RemoveScoreListener() {
        scoreListenerEntity.Destroy();
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public ScoreListenerComponent scoreListener { get { return (ScoreListenerComponent)GetComponent(GameStateComponentsLookup.ScoreListener); } }
    public bool hasScoreListener { get { return HasComponent(GameStateComponentsLookup.ScoreListener); } }

    public void AddScoreListener(IScoreListener newValue) {
        var index = GameStateComponentsLookup.ScoreListener;
        var component = CreateComponent<ScoreListenerComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceScoreListener(IScoreListener newValue) {
        var index = GameStateComponentsLookup.ScoreListener;
        var component = CreateComponent<ScoreListenerComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveScoreListener() {
        RemoveComponent(GameStateComponentsLookup.ScoreListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameStateMatcher {

    static Entitas.IMatcher<GameStateEntity> _matcherScoreListener;

    public static Entitas.IMatcher<GameStateEntity> ScoreListener {
        get {
            if (_matcherScoreListener == null) {
                var matcher = (Entitas.Matcher<GameStateEntity>)Entitas.Matcher<GameStateEntity>.AllOf(GameStateComponentsLookup.ScoreListener);
                matcher.componentNames = GameStateComponentsLookup.componentNames;
                _matcherScoreListener = matcher;
            }

            return _matcherScoreListener;
        }
    }
}