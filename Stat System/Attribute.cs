/// <summary>
/// Attribute.cs
/// Bryan Wilger
/// May 7th, 2019
/// 
/// This is the class for all character attributes in-game
/// </summary>
namespace Wilgersoft.StatSystem
{
    public enum CoreStatName
    {
        STRENGTH,
        DEXTERITY,
        CONSTITUTION,
        INTELLIGENCE,
        WISDOM,
        CHARISMA
    }

    [System.Serializable]
    public class CoreStat : BaseStat
    {

        /// <summary>
        /// Initializes a new instance of the Attribute class
        /// </summary>
        public CoreStat()
        {

        }
    }
}
