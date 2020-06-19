using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wilgersoft.StatSystem
{
    public enum VitalName
    {
        SHIELD,
        HEALTH,
        MANA
    }

    [System.Serializable]
    public class Vital : ModifiedStat
    {
        [SerializeField]float _curValue;

        public Vital()
        {
            _curValue = 0;
        }

        public float CurValue
        {
            get
            {
                if(_curValue > AdjustedBaseValue)
                {
                    _curValue = AdjustedBaseValue;
                }

                return _curValue;
            }
            set
            {
                _curValue = value;
            }
        }
    }
}