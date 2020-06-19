using UnityEngine;

/// <summary>
/// BaseStat.cs
/// Bryan Wilger
/// May 7th, 2019
/// 
/// The base class for all in-game stats
/// </summary>

namespace Wilgersoft.StatSystem
{
    public class BaseStat
    {
        #region Fields
        public const int STARTING_EXP_COST = 100;   //publicly accessible value for all stats to start at

        [SerializeField]string _name;
        [SerializeField]float _baseValue;             //the base value of this stat
        [SerializeField]float _buffValue;             //the amount of the buff to this stat
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the BaseStat class
        /// </summary>
        public BaseStat()
        {
            _baseValue = 0;
            _buffValue = 0;
        }
        #endregion

        #region Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public float BaseValue
        {
            get
            {
                return _baseValue;
            }

            set
            {
                _baseValue = value;
            }
        }

        public float BuffValue
        {
            get
            {
                return _buffValue;
            }

            set
            {
                _buffValue = value;
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Recalculate the AdjustedBaseValue and return it
        /// </summary>
        public float AdjustedBaseValue
        {
            get {
                return _baseValue + _buffValue;
            }
        }

        #endregion
    }
}
