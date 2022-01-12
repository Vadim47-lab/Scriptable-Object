using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( menuName = "Abillities/New Abillity", order = 51)]
public class Abillity : ScriptableObject
{
    [SerializeField] private AbillityPlaceLogic _placeLogic;
    [SerializeField] private List<AbilityAction> _abilityAction;

    public void ApplyAction (List<Unit> targets)
    {
        foreach (var action in _abilityAction)
        {
            foreach (var target in targets)
            {
                action.Action(target);
            }
        }
    }

    public List<Unit> SelectTargets(Vector2 screenPoint)
    {
        return _placeLogic.TryGetTargets(screenPoint);
    }
}