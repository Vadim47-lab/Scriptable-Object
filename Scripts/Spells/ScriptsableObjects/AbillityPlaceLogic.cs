using System.Collections.Generic;
using UnityEngine;

public abstract class AbillityPlaceLogic : ScriptableObject
{
    public abstract List<Unit> TryGetTargets(Vector2 screenPoint);
}