/// <summary>
/// Skill.cs
/// Bryan Wilger
/// May 7th, 2019
/// 
/// 
/// </summary>

namespace Wilgersoft.StatSystem
{
    public enum SkillName
    {
        MIN_PHYSICAL_ATTACK,
        MAX_PHYSICAL_ATTACK,
        PHYSICAL_DEFENSE,
        MIN_MAGIC_ATTACK,
        MAX_MAGIC_ATTACK,
        MAGIC_DEFENSE,
        MIN_RANGE,
        MAX_RANGE,
        ATTACK_SPEED,
        MOVE_SPEED,
        DAY_VISION,
        NIGHT_VISION
    }

    [System.Serializable]
    public class Skill : ModifiedStat
    {
        public Skill()
        {
        }
    }
}
