using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wilgersoft.ItemSystem.Editor
{
    public partial class ISObjectDatabaseType<D, T> where D : ScriptableObjectDatabase<T> where T : ISObject, new()
    {
        int _selectedIndex = -1;                //-1 means that nothing is selected
        T tempItem;
        bool showDetails = false;
        bool createNewArmour = false;
        Vector2 _scrollPos = Vector2.zero;

        public void ListView(Vector2 buttonSize, int listViewWidth)
        {
            if(showDetails)
            {
                return;
            }

            _scrollPos = GUILayout.BeginScrollView(_scrollPos, "Box", GUILayout.ExpandHeight(true), GUILayout.Width(listViewWidth));

            for (int cnt = 0; cnt < _database.Count; cnt++)
            {
                if (GUILayout.Button(_database.Get(cnt).Name, "box", GUILayout.Width(buttonSize.x), GUILayout.Height(buttonSize.y)))
                {
                    _selectedIndex = cnt;
                    tempItem = new T();
                    tempItem.Clone(_database.Get(cnt));
                    createNewArmour = true;
                    showDetails = true;
                }
            }

            GUILayout.EndScrollView();
        }
    }
}
