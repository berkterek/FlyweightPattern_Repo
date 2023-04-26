
public class Stats
{
    public class StatsSolution1
    {
        public const int MaxHealth = 100;
        public const int MaxDamage = 100;
        public const float MoveSpeed = 5f;
    }

    public class StatsSolution2
    {
        public static int MaxHealth = 100;
        public static int MaxDamage = 100;
        public static float MoveSpeed = 5f;
    }

    public class StatsSolution3
    {
        public int MaxHealth { get; set; } = 100;
        public int MaxDamage { get; set; } = 100;
        public float MoveSpeed { get; set; } = 5f;
    }
}