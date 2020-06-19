using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ModifiedStat.cs
/// Bryan Wilger
/// May 7th, 2019
/// 
/// This is the base class for all stats that will be modifiable by attributes
/// </summary>
namespace Wilgersoft.StatSystem
{
    public class ModifiedStat : BaseStat
    {
        private List<ModifyingCoreStat> _mods;         //A list of attributes that modify this stat
        private float _modValue;                          //The amount added to the base value from the modifiers

        /// <summary>
        /// Initializes a new instance of the ModifiedStat class.
        /// </summary>
        public ModifiedStat()
        {
            _mods = new List<ModifyingCoreStat>();
            _modValue = 0;
        }

        /// <summary>
        /// Add a ModifyingAttribute to the list of mods for this ModifiedStat
        /// </summary>
        /// <param name="mod">
        /// Mod
        /// </param>
        public void AddModifier(ModifyingCoreStat mod)
        {
            _mods.Add(mod);
        }

        /// <summary>
        /// Reset mod value to 0.
        /// Check to see if we have at least one modifying attribute in our list of mods.
        /// If we do, then iterate through the list and add the AdjustedBaseValue * ratio of our _modValue.
        /// </summary>
        private void CalculateModValue()
        {
            _modValue = 0;

            if(_mods.Count > 0)
            {
                foreach(ModifyingCoreStat att in _mods)
                {
                    _modValue += (int)(att.coreStat.AdjustedBaseValue * att.ratio);
                }
            }
        }

        /// <summary>
        /// Overriding from BaseStat
        /// Calculate the AdjustedBaseValue
        /// </summary>
        public new float AdjustedBaseValue
        {
            get
            {
                return BaseValue + BuffValue + _modValue;
            }
        }

        /// <summary>
        /// Update this instance.
        /// </summary>
        public void Update()
        {
            CalculateModValue();
        }
    }

    /// <summary>
    /// A structure that will hold an Attribute and a Ratio to be added as a modifier.
    /// </summary>
    public struct ModifyingCoreStat
    {
        public CoreStat coreStat;         //the Attribute to use
        public float ratio;                 //the percentage to be used

        /// <summary>
        /// 
        /// </summary>
        /// <param name="crst"></param>
        /// <param name="rat"></param>
        public ModifyingCoreStat(CoreStat crst, float rat)
        {
            coreStat = crst;
            ratio = rat;
        }
    }
}
