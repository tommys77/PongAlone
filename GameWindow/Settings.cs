using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWindow
{
    public static class Settings
    {
        private static int speedIncrements = 10;
        private static int maxSpeed = 40;

        // Boolean to keep track of the balls current direction, when raising speed up or down.
        private static bool yIsPositive;
        private static bool xIsPositive;

        public static int XSpeed { get; private set; } = 10;
        public static int YSpeed { get; private set; } = -10;

        #region public methods

        public static void IncreaseSpeed()
        {
            if (Math.Abs(XSpeed) != 40 || Math.Abs(YSpeed) != 40)
            {
                RaiseHorizontalSpeed();
                RaiseVerticalSpeed();
            }
        }

        public static void DecreaseSpeed()
        {
            if ((XSpeed != 0 && YSpeed != 0))
            {
                LowerHorizontalSpeed();
                LowerVerticalSpeed();
            }
        }

        public static void SetSpeedIncrements(int s)
        {
            speedIncrements = 10;
        }

        public static void DefaultSpeedSettings()
        {
            XSpeed = 10;
            YSpeed = -10;
            speedIncrements = 10;
        }

        public static void ReverseX()
        {
            XSpeed = -XSpeed;
        }

        public static void ReverseY()
        {
            YSpeed = -YSpeed;
        }

        #endregion

        private static void RaiseHorizontalSpeed()
        {
            if (XSpeed > 0)
            {
                xIsPositive = true;
                XSpeed += speedIncrements;
            }
            else if (XSpeed < 0)
            {
                xIsPositive = false;
                XSpeed -= speedIncrements;
            }
            else if (XSpeed == 0)
            {
                if (xIsPositive)
                {
                    XSpeed += speedIncrements;
                }
                else XSpeed -= speedIncrements;
            }
        }

        private static void RaiseVerticalSpeed()
        {
            if (YSpeed > 0)
            {
                yIsPositive = true;
                YSpeed += speedIncrements;
            }
            else if (YSpeed < 0)
            {
                yIsPositive = false;
                YSpeed -= speedIncrements;
            }
            else if (YSpeed == 0)
            {
                if (yIsPositive)
                {
                    YSpeed += speedIncrements;
                }
                else YSpeed -= speedIncrements;
            }
        }

        private static void LowerHorizontalSpeed()
        {
            if (XSpeed > 0)
            {
                xIsPositive = true;
                XSpeed -= speedIncrements;
            }
            else if (XSpeed < 0)
            {
                xIsPositive = false;
                XSpeed += speedIncrements;
            }
        }

        private static void LowerVerticalSpeed()
        {

            if (YSpeed > 0)
            {
                yIsPositive = true;
                YSpeed -= speedIncrements;
            }
            else if (YSpeed < 0)
            {
                yIsPositive = false;
                YSpeed += speedIncrements;
            }
        }

    }
}
