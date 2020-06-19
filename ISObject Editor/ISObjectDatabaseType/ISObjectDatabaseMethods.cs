using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Wilgersoft.ItemSystem.Editor
{
    public partial class ISObjectDatabaseType<D, T> where D : ScriptableObjectDatabase<T> where T : ISObject, new()
    {
        void LoadDatabase()
        {
            string dbFullPath = @"Assets/" + dbPath + "/" + dbName;

            //load the database
            _database = AssetDatabase.LoadAssetAtPath(dbFullPath, typeof(D)) as D;

            //if we could not load the database, create one
            if (_database == null)
            {
                CreateDatabase(dbFullPath);
            }
        }

        void CreateDatabase(string dbFullPath)
        {
            //check to see if the folder exists
            if (!AssetDatabase.IsValidFolder(@"Assets/" + dbPath))
            {
                AssetDatabase.CreateFolder(@"Assets/", dbPath);
            }

            //create the database and refresh the AssetDatabase
            _database = ScriptableObject.CreateInstance<D>() as D;
            AssetDatabase.CreateAsset(_database, dbFullPath);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        public void Add(T item)
        {
            _database.Item.Add(item);

            EditorUtility.SetDirty(_database);

        }

        public void Insert(int index, T item)
        {
            _database.Item.Insert(index, item);
            EditorUtility.SetDirty(_database);
        }

        public void Remove(T item)
        {
            _database.Item.Remove(item);
            EditorUtility.SetDirty(_database);
        }

        public void Remove(int index)
        {
            _database.Item.RemoveAt(index);
            EditorUtility.SetDirty(_database);
        }

        public void Replace(int index, T item)
        {
            _database.Item[index] = item;
            EditorUtility.SetDirty(_database);
        }

        public void Update()
        {
            EditorUtility.SetDirty(_database);
        }
    }
}