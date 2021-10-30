using UnityEngine;
using Random = System.Random;

namespace PW2.Scripts.CommonUtilities
{
    public static class MyRandom
    {
        private static readonly Random sysRandom = new Random(666);

        static MyRandom()
        {
            UnityEngine.Random.InitState(666);
        }

        public static Color Color()
        {
            return UnityEngine.Random.ColorHSV();
        }

        public static int GetInt(int maxvalue)
        {
            return sysRandom.Next(maxvalue);
        }
    }
}