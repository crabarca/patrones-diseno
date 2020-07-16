using System;
using System.Collections.Generic;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void DrawWithoutFlyweight()
        {
            var bullets = new List<Bullet>();
            for (int i = 0; i < 100000; i++)
            {
                bullets.Add(Bullet.GetRandomBullet());
            }

            foreach (var bullet in bullets)
            {
                bullet.Draw();
            }
        }

        public void DrawWithFlyweight()
        {
            var states = new List<Bullet.ExtrinsicState>();
            var bulletTypes = new List<Bullet.BulletType>();
            
            for (int i = 0; i < 100000; i++)
            {
                states.Add(Bullet.GetRandomExtrinsicState());
                bulletTypes.Add(Bullet.GetRandomBulletType());
            }

            Bullet bullet;
            for (int i = 0; i < 100000; i++)
            {
                bullet = FlyweightFactory.GetFlyweight(bulletTypes[i]);
                bullet.ExState = states[i];
                bullet.Draw();
            }
            
        }
    }
}