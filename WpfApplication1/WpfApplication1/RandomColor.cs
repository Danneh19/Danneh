using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApplication1
{
    public static class RandomColor
    {
        private static Random random = new Random();
        public static int generateNumber(int min, int max)
        {
            return RandomColor.random.Next(min, max + 1);
        }

        public static Color getColor()
        {
            int[] argb = new int[4];
            argb[0] += RandomColor.generateNumber(0, 255);
            
            for (int colorIndex = 1; colorIndex < 4; colorIndex++)
            {
                argb[colorIndex] = RandomColor.generateNumber(0, 255);
            }

            return Color.FromArgb((byte)argb[0], (byte)argb[1], (byte)argb[2], (byte)argb[3]);
        }
    }
}
