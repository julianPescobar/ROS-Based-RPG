using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Input;
using OpenTK.Graphics;
using SunshineConsole;

namespace contest1
{
   public class pj
    {
        public static string simbol = "@";
        public static int x, y;
        public static string nombre, clase, titulo;
        public static int level, exp, next, chp, mhp, cmp, mmp, str, agi, vit;
        public static  void readmovement(ConsoleWindow console)
        {
            
                Key key = console.GetKey();

                if (key.ToString() == "Right" || key.ToString() == "D")
                {
                    if ( pj.y < console.Cols-35)
                    {
                        console.Write(pj.x, pj.y, " ", Color4.White, console.GetBackgroundColor(pj.x, pj.y));
                        pj.y++;
                        console.Write(pj.x, pj.y, pj.simbol, Color4.White, console.GetBackgroundColor(pj.x, pj.y));
                    }
                }
                if (key.ToString() == "Up" || key.ToString() == "W")
                {
                    if (pj.x > 0 )
                    {
                        console.Write(pj.x, pj.y, " ", Color4.White, console.GetBackgroundColor(pj.x, pj.y));
                        pj.x--;
                        console.Write(pj.x, pj.y, pj.simbol, Color4.White, console.GetBackgroundColor(pj.x, pj.y));
                    }
                }
                if (key.ToString() == "Down" || key.ToString() == "S")
                {
                    if ( pj.x < console.Rows-5)
                    {
                        console.Write(pj.x, pj.y, " ", Color4.White, console.GetBackgroundColor(pj.x, pj.y));
                        pj.x++;
                        console.Write(pj.x, pj.y, pj.simbol, Color4.White, console.GetBackgroundColor(pj.x, pj.y));
                    }
                }
                if (key.ToString() == "Left" || key.ToString() == "A")
                {
                    if (pj.y > 0)
                    {
                        console.Write(pj.x, pj.y, " ", Color4.White, console.GetBackgroundColor(pj.x, pj.y));
                        pj.y--;
                        console.Write(pj.x, pj.y, pj.simbol, Color4.White, console.GetBackgroundColor(pj.x, pj.y));
                    }
                }
              
          
           
        }
    }
}
