
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wilgersoft.ItemSystem.Editor
{
    public partial class ISObjectDatabaseEditor : EditorWindow
    {
        Vector2 _buttonSize = new Vector2(190, 25);
        int _listViewWidth = 200;

        ISObjectDatabaseType<ISWeaponDatabase, ISWeapon> weaponDatabase = new ISObjectDatabaseType<ISWeaponDatabase, ISWeapon>(@"wilgersoftWeaponDatabase.asset");
        ISObjectDatabaseType<ISArmourDatabase, ISArmour> armourDatabase = new ISObjectDatabaseType<ISArmourDatabase, ISArmour>(@"wilgersoftArmourDatabase.asset");
        ISObjectDatabaseType<ISConsumableDatabase, ISConsumable> consumableDatabase = new ISObjectDatabaseType<ISConsumableDatabase, ISConsumable>(@"wilgersoftConsumableDatabase.asset");


        const string DATABASE_FILE_NAME = @"WilgersoftWeaponDatabase.asset";
        const string DATABASE_FOLDER_NAME = @"Database";
        const string DATABASE_FULL_PATH = @"Assets/" + DATABASE_FOLDER_NAME + "/" + DATABASE_FILE_NAME;



        [MenuItem("Wilgersoft/Database/Item System/Item System Editor %#i")]
        public static void Init()
        {
            ISObjectDatabaseEditor window = GetWindow<ISObjectDatabaseEditor>();
            window.minSize = new Vector2(800, 600);
            window.titleContent.text = "Item System Database";
            window.Show();
        }

        void OnEnable()
        {
            weaponDatabase.OnEnable("Weapon");
            armourDatabase.OnEnable("Armour");
            consumableDatabase.OnEnable("Consumable");

            tabState = TabState.ABOUT;
        }

        void OnGUI()
        {
            TopTabBar();

            GUILayout.BeginHorizontal();

            switch(tabState)
            {
                case TabState.WEAPON:
                    weaponDatabase.OnGUI(_buttonSize, _listViewWidth);
                    break;
                case TabState.ARMOUR:
                    armourDatabase.OnGUI(_buttonSize, _listViewWidth);
                    break;
                case TabState.CONSUMABLE:
                    consumableDatabase.OnGUI(_buttonSize, _listViewWidth);
                    break;
                default:
                    GUILayout.Label("State: " + tabState);
                    break;
            }

            GUILayout.EndHorizontal();

            BottomStatusBar();
        }
    }
}