using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Wilgersoft.ItemSystem.Editor
{
    public partial class ISObjectDatabaseType<D, T> where D : ScriptableObjectDatabase<T> where T : ISObject, new()
    {
        [SerializeField]D _database;
        [SerializeField]string dbName;
        [SerializeField] string dbPath = @"Database";
        string strItemType;

        public D Database
        {
            get
            {
                return _database;
            }
        }

        public ISObjectDatabaseType(string n)
        {
            dbName = n;
        }

        public void OnEnable(string itemType)
        {
            strItemType = itemType;

            if (_database == null)
            {
                LoadDatabase();
            }
        }

        public void OnGUI(Vector2 buttonSize, int listViewWidth)
        {
            ListView(buttonSize, listViewWidth);
            DetailView();
        }
    }
}