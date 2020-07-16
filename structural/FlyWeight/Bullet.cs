using System;
using System.Collections.Generic;

namespace FlyWeight
{
    public class Bullet
    {
        public enum BulletType
        {
            Type1, Type2, Type3
        }

        public static Random Random = new Random();

        public static Dictionary<BulletType, IntrinsicState> Cache = new Dictionary<BulletType, IntrinsicState>
        {
            {
                BulletType.Type1, new IntrinsicState(10, "A", 100)
            },
            {
                BulletType.Type2, new IntrinsicState(20, "B", 30)
            },
            {
                BulletType.Type3, new IntrinsicState(30, "C", 10)
            }
        };

        public ExtrinsicState ExState { get; set; }
        public IntrinsicState InState { get; set; }
        
        

        public Bullet(ExtrinsicState extrinsicState, IntrinsicState intrinsicState)
        {
            ExState = extrinsicState;
            InState = intrinsicState;
        }

        public void Draw()
        {
            Console.WriteLine($"X: {ExState.X} - Y: {ExState.Y} - Orientation: {ExState.Orientation} - Speed: {InState.Speed} - Sprite: {InState.Sprite} - Radius: {InState.Radius}");
        }

        public static ExtrinsicState GetRandomExtrinsicState()
        {
            return new ExtrinsicState(Random.Next(100), Random.Next(100), Random.Next(360));
        }

        public static Bullet GetRandomBullet()
        {
            int x = Random.Next(3);
            IntrinsicState state;
            if (x == 0)
            {
                state = Cache[BulletType.Type1];
            }
            else if (x == 1)
            {
                state = Cache[BulletType.Type2];
            }
            else 
            {
                state = Cache[BulletType.Type3];
            }

            var extrinsicState = GetRandomExtrinsicState();

            return new Bullet(extrinsicState, state);
        }

        public static BulletType GetRandomBulletType()
        {
            int x = Random.Next(3);
            if (x == 0)
            {
                return BulletType.Type1;
            }
            else if (x == 1)
            {
                return BulletType.Type2;
            }
            else
            {
                return BulletType.Type3;
            }
        }

        public class ExtrinsicState
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Orientation { get; set; }

            public ExtrinsicState(int x, int y, int orientation)
            {
                X = x;
                Y = y;
                Orientation = orientation;
            }
        }

        public class IntrinsicState
        {
            public int Speed { get; set; }
            public string Sprite { get; set; }
            public int Radius { get; set; }

            public IntrinsicState(int speed, string sprite, int radius)
            {
                Speed = speed;
                Sprite = sprite;
                Radius = radius;
            }
        }
    }
}