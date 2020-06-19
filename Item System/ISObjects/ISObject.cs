#if UNITY_EDITOR
using UnityEditor;
#endif

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wilgersoft.ItemSystem
{
    [System.Serializable]
    public class ISObject
    {
        [SerializeField] string _name;
        [SerializeField] int _value;
        [SerializeField] Texture2D _icon;
        [SerializeField] Qualities _quality;
        [SerializeField] bool _isEssential;

        public ISObject()
        {
        }

        public ISObject(ISObject item)
        {
            Clone(item);
        }

        public void Clone(ISObject item)
        {
            _name = item.Name;
            _value = item.Value;
            _icon = item.Icon;
            _quality = item.Quality;
            _isEssential = item.IsEssential;
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

        public int Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
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

        public Qualities Quality
        {
            get
            {
                return _quality;
            }

            set
            {
                _quality = value;
            }
        }

        public bool IsEssential
        {
            get
            {
                return _isEssential;
            }
            set
            {
                _isEssential = value;
            }
        }

        //this code is going to be placed in a separate class later on
#if UNITY_EDITOR

        public virtual void OnGUI()
        {

            _name = EditorGUILayout.TextField("Name: ", _name);
            _value = EditorGUILayout.IntField("Value: ", _value);

            DisplayIcon();

            DisplayQuality();

            DisplayIsEssential();
        }

        public void DisplayIcon()
        {
            _icon = EditorGUILayout.ObjectField("Icon:", _icon, typeof(Texture2D), false) as Texture2D;
        }

        public void DisplayQuality()
        {
            _quality = (Qualities)EditorGUILayout.EnumPopup("Quality: ", _quality);
        }

        public void DisplayIsEssential()
        {
            _isEssential = EditorGUILayout.Toggle("Essential: ", _isEssential);
        }
#endif
    }
}