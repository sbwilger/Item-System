using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wilgersoft.StatSystem;

#if UNITY_EDITOR
using UnityEditor;
#endif 

namespace Wilgersoft.ItemSystem
{
    [System.Serializable]
    public class ISWeapon : ISArmour
    {
#region Fields

        [SerializeField] CoreStatName _attackStat;
        [SerializeField] bool _canTargetLandUnits;
        [SerializeField] bool _canTargetAirUnits;

#endregion

#region Constructors

        public ISWeapon() : base()
        {
        }

        public ISWeapon(ISWeapon weapon)
        {
            Clone(weapon);
        }

#endregion

#region Properties

        public CoreStatName AttackStat
        {
            get
            {
                return _attackStat;
            }
        }

        public bool CanTargetLandUnits
        {
            get
            {
                return _canTargetLandUnits;
            }

            set
            {
                _canTargetLandUnits = value;
            }
        }

        public bool CanTargetAirUnits
        {
            get
            {
                return _canTargetAirUnits;
            }

            set
            {
                _canTargetAirUnits = value;
            }
        }

#endregion

#region Methods

        public int Attack()
        {
            throw new System.NotImplementedException();
        }

        public void Clone(ISWeapon weapon)
        {
            base.Clone(weapon);
            _attackStat = weapon.AttackStat;
            _canTargetLandUnits = weapon.CanTargetLandUnits;
            _canTargetAirUnits = weapon._canTargetAirUnits;
        }

#endregion

        //this code is going to be placed in a separate class later on
#if UNITY_EDITOR
        int attackStatSelectedIndex;

        public override void OnGUI()
        {
            base.OnGUI();

            DisplayAttackStat();

            DisplayValidTargets();
        }

        public void DisplayAttackStat()
        {
            _attackStat = (CoreStatName)EditorGUILayout.EnumPopup("Attack Statistic: ", _attackStat);
        }

        public void DisplayValidTargets()
        {
            _canTargetLandUnits = EditorGUILayout.Toggle("Can Target Land Units: ", _canTargetLandUnits);
            _canTargetAirUnits = EditorGUILayout.Toggle("Can Target Air Units: ", _canTargetAirUnits);
        }
#endif
    }
}
