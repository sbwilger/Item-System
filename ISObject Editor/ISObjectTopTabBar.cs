using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wilgersoft.ItemSystem.Editor
{
    public partial class ISObjectDatabaseEditor
    {
        enum TabState
        {
            WEAPON,
            ARMOUR,
            CONSUMABLE,
            ABOUT
        }

        TabState tabState;

        void TopTabBar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));

            WeaponTab();
            ArmourTab();
            ConsumablesTab();
            AboutTab();

            GUILayout.EndHorizontal();

            void WeaponTab()
            {
                if(GUILayout.Button("Weapons"))
                {
                    tabState = TabState.WEAPON;
                }
            }

            void ArmourTab()
            {
                if(GUILayout.Button("Armours"))
                {
                    tabState = TabState.ARMOUR;
                }
            }

            void ConsumablesTab()
            {
               if(GUILayout.Button("Consumables"))
                {
                    tabState = TabState.CONSUMABLE;
                }
            }

            void AboutTab()
            {
                if(GUILayout.Button("About"))
                {
                    tabState = TabState.ABOUT;
                }
            }
        }
    }
}