using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abillities/Actions/Damage", order = 51)]
public class AbilityActionDamage : AbilityAction
{
    [SerializeField] private float _damage;

    public override void Action(Unit target)
    {
        
    }
}