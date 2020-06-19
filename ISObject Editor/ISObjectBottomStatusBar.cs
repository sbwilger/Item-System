using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wilgersoft.ItemSystem.Editor
{
    public partial class ISObjectDatabaseEditor
    {
        void BottomStatusBar()
        {
            GUILayout.BeginHorizontal("Box", GUILayout.ExpandWidth(true));

            GUILayout.Label("Status Bar");

            GUILayout.EndHorizontal();
        }
    }
}
