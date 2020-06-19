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
    public class ISArmour : ISObject
    {
        #region Fields

        [SerializeField] EquipmentSlot _equipmentSlot;
        [SerializeField] GameObject _prefab;
        [SerializeField] float[] _vitalSteals = new float[3];
        [SerializeField] float[] _attributeBuffs = new float[6];
        [SerializeField] float[] _skillBuffs = new float[12];
        [SerializeField] float[] _vitalBuffs = new float[3];
        [SerializeField] string _flavourText;

        #endregion

        #region Properties

        public EquipmentSlot EquipmentSlot
        {
            get
            {
                return _equipmentSlot;
            }
        }

        public GameObject Prefab
        {
            get
            {
                return _prefab;
            }

            set
            {
                _prefab = value;
            }
        }

        public float[] VitalStealPercentages
        {
            get
            {
                return _vitalSteals;
            }
            set
            {
                _vitalSteals = value;
            }
        }

        public float[] AttributeBuffs
        {
            get
            {
                return _attributeBuffs;
            }
        }

        public float[] SkillBuffs
        {
            get
            {
                return _skillBuffs;
            }
        }

        public float[] VitalBuffs
        {
            get
            {
                return _vitalBuffs;
            }
        }

        public string FlavourText
        {
            get
            {
                return _flavourText;
            }

            set
            {
                _flavourText = value;
            }
        }

        #endregion

        #region Constructors

        public ISArmour() : base()
        {

        }

        public ISArmour(ISArmour armour)
        {

            Clone(armour);
        }

        #endregion

        #region Methods

        public bool Equip()
        {
            throw new System.NotImplementedException();
        }

        public void Clone(ISArmour armour)
        {
            base.Clone(armour);
            _equipmentSlot = armour.EquipmentSlot;
            _prefab = armour.Prefab;
            _vitalSteals = armour.VitalStealPercentages;
            _attributeBuffs = armour.AttributeBuffs;
            _skillBuffs = armour.SkillBuffs;
            _vitalBuffs = armour.VitalBuffs;
        }

        #endregion

        //this code is going to be placed in a separate class later on
#if UNITY_EDITOR

        public override void OnGUI()
        {
            base.OnGUI();

            DisplayEquipmentSlot();

            DisplayVitalSteals();

            DisplayBuffs();

            DisplayPrefab();

            DisplayFlavourText();
        }

        public void DisplayEquipmentSlot()
        {

            _equipmentSlot = (EquipmentSlot)EditorGUILayout.EnumPopup("Equipment Slot: ", _equipmentSlot);
        }

        public void DisplayVitalSteals()
        {

            for (int cnt = 0; cnt < 3; cnt++)
            {

                _vitalSteals[cnt] = EditorGUILayout.FloatField(((VitalName)cnt).ToString() + " Steal: ", _vitalSteals[cnt]);

            }
        }

        public void DisplayBuffs()
        {
            EditorGUILayout.LabelField("Attribute Buffs");

            for (int cnt = 0; cnt < 6; cnt++)
            {
                _attributeBuffs[cnt] = EditorGUILayout.FloatField(((CoreStatName)cnt).ToString() + ": ", _attributeBuffs[cnt]);
            }

            EditorGUILayout.LabelField("Skill Buffs");

            for (int cnt = 0; cnt < 12; cnt++)
            {
                _skillBuffs[cnt] = EditorGUILayout.FloatField(((SkillName)cnt).ToString() + ": ", _skillBuffs[cnt]);
            }

            EditorGUILayout.LabelField("Vital Buffs");

            for (int cnt = 0; cnt < 3; cnt++)
            {
                _vitalBuffs[cnt] = EditorGUILayout.FloatField(((VitalName)cnt).ToString() + ": ", _vitalBuffs[cnt]);
            }
        }

        public void DisplayPrefab()
        {
            _prefab = EditorGUILayout.ObjectField("Prefab:", _prefab, typeof(GameObject), false) as GameObject;
        }

        public void DisplayFlavourText()
        {
            _flavourText = EditorGUILayout.TextField("Flavour Text: ", _flavourText);
        }

#endif
    }
}