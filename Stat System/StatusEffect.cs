using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wilgersoft.StatSystem
{
    public enum StatusEffectType
    {
        BLEEDING,
        ON_FIRE,
        PETRIFIED,
        POISONED,
        SLEEPING,
        SLOWED,
        STUNNED
    }

    public struct StatusEffect
    {
        StatusEffectType type;
        float potency;
        float duration;
    }

}