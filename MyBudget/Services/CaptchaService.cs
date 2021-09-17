using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Services
{
    static class CaptchaService
    {
        public static Bitmap Create(int Width, int Height)
        {
            Random rnd = new Random();

            Bitmap result = new Bitmap(Width, Height);

            int Xpos = rnd.Next(0, Width - 50);
            int Ypos = rnd.Next(15, Height - 15);

            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue };

            Graphics g = Graphics.FromImage(result);

            g.Clear(Color.DarkGray);

            string text = String.Empty,
                   ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";

            for (int i = 0; i < 5; ++i)
            {
                text += ALF[rnd.Next(ALF.Length)];
            }

            g.DrawString(text,
                         new Font("Arial", 16),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));

            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));

            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));

            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }
    }
}
