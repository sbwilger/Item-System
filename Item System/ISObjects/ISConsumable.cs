using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wilgersoft.ItemSystem
{
    public enum CastType
    {
        AREA_OF_EFFECT,
        CAST_ON_USER,
        SELECT,
        SKILL_SHOT
    }

    [System.Serializable]
    public class ISConsumable : ISArmour
    {
        public void Use()
        {

        }
    }
}