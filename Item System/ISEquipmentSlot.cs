using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wilgersoft.ItemSystem
{
    public enum EquipmentSlot
    {
        WEAPON,
        BAG
    }

    [System.Serializable]
    public class ISEquipmentSlot
    {
        [SerializeField]string _name;
        [SerializeField]Texture2D _icon;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public Texture2D Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
            }
        }
    }
}