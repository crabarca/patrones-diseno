using System.Collections.Generic;

namespace FlyWeight
{
    public class FlyweightFactory
    {
        public static Dictionary<Bullet.BulletType, Bullet> Cache = new Dictionary<Bullet.BulletType, Bullet>();

        public static Bullet GetFlyweight(Bullet.BulletType type)
        {
            if (!Cache.ContainsKey(type))
            {
                Cache[type] = new Bullet(null, Bullet.Cache[type]);
            }

            return Cache[type];
        }
    }
}