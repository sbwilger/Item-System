using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wilgersoft
{
    public abstract class HasIcon
    {
        [SerializeField] string _name;
        [SerializeField] Texture2D _icon;


        public HasIcon()
        {
            _name = "";
            _icon = null;
        }

        public HasIcon(string name, Texture2D icon)
        {
            _name = name;
            _icon = icon;
        }



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