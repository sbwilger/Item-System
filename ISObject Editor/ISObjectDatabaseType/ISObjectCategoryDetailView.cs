using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Wilgersoft.ItemSystem.Editor
{
    public partial class ISObjectDatabaseType<D, T> where D : ScriptableObjectDatabase<T> where T : ISObject, new()
    {
        public void DetailView()
        {
            GUILayout.BeginVertical("Box", GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));
            GUILayout.BeginVertical(GUILayout.ExpandWidth(true), GUILayout.ExpandHeight(true));

            if(showDetails)
            {
                tempItem.OnGUI();
            }

            GUILayout.EndVertical();

            GUILayout.Space(50);
            GUILayout.BeginHorizontal(GUILayout.ExpandWidth(true));

            DisplayButtons();

            GUILayout.EndHorizontal();
            GUILayout.EndVertical();
        }

        void DisplayButtons()
        {
            if(showDetails)
            {
                SaveButton();

                if(_selectedIndex != -1)
                {
                    DeleteButton();
                }

                CancelButton();
            }
            else
            {
                CreateItemButton();
            }
        }

        void CreateItemButton()
        {
            if(!createNewArmour)
            {
                if(GUILayout.Button("Create " + strItemType))
                {
                    tempItem = new T();
                    createNewArmour = true;
                    showDetails = true;
                }
            }
        }

        void SaveButton()
        {
            GUI.SetNextControlName("SaveButton");
            if(GUILayout.Button("Save"))
            {

                if(_selectedIndex == -1)
                {
                    Add(tempItem);
                }
                else
                {
                    Replace(_selectedIndex, tempItem);
                }

                createNewArmour = false;
                tempItem = null;
                _selectedIndex = -1;
                showDetails = false;
                GUI.FocusControl("SaveButton");

            }
        }

        void CancelButton()
        {
            if(GUILayout.Button("Cancel"))
            {
                tempItem = null;
                showDetails = false;
                createNewArmour = false;
                _selectedIndex = -1;
                GUI.FocusControl("SaveButton");
            }
        }

        void DeleteButton()
        {
            if (GUILayout.Button("Delete"))
            {
                if (EditorUtility.DisplayDialog("Delete " + strItemType, "Are you sure you want to delete " + tempItem.Name + " from the database?", "Delete", "Cancel"))
                {
                    Remove(_selectedIndex);

                    tempItem = null;
                    showDetails = false;
                    createNewArmour = false;
                    _selectedIndex = -1;
                    GUI.FocusControl("SaveButton");
                }
            }
        }
    }
}
