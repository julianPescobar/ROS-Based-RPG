using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Graphics;

namespace contest1
{
    public class Game
    {
        
        public static void update()
        {
           
            mouse();
            printdisplay();
            
        }
        public static void mouse()
        {
            int mousex = Form1.console.Mouse.X / 8;
            int mousey = Form1.console.Mouse.Y / 12;
            if (mousex >= 0 && mousex < Form1.console.Cols - 1 && mousey >= 0 && mousey < Form1.console.Rows - 1)
            {
                Form1.console.Write(Form1.console.Rows - 1, 0, String.Empty.PadRight(Form1.console.Cols, ' '), Color4.Black);
                //.console.Write(Form1.console.Rows - 1, 0, "Mouse Coords(Y" + mousey + ",X" + mousex + ")", Color4.White);
                //Form1.console.Write(Form1.console.Rows - 2, 0, String.Empty.PadRight(Form1.console.Cols, ' '), Color4.Black);
                //Form1.console.Write(Form1.console.Rows - 2, 0, "Celda:(BColor: " + Form1.console.GetBackgroundColor(mousey, mousex).ToArgb().ToString() + " FColor: " + Form1.console.GetColor(mousey, mousex).ToArgb().ToString() + " Char: '" + Form1.console.GetChar(mousey, mousex) + "'", Color4.Blue);
                string elchar = Form1.console.GetChar(mousey, mousex).ToString();

                if (bestiary.kaka.FindIndex(chr => chr.simbolo.Equals(elchar, StringComparison.InvariantCulture)) != -1)
                {
                    int index = bestiary.kaka.FindIndex(chr => chr.simbolo.Equals(elchar, StringComparison.InvariantCulture));
                    string descr = "";
                    if (bestiary.kaka[index].hp < pj.mhp) descr = "Parece fragil";
                    if (bestiary.kaka[index].hp == pj.mhp) descr = "Parece fuerte";
                    if (bestiary.kaka[index].hp > pj.mhp) descr = "Parece peligroso";
                    Form1.console.Write(Form1.console.Rows - 3, 0, "Ves a " + bestiary.kaka[index].name + ". " + descr, Color4.White);
                    Form1.console.Write(Form1.console.Rows - 2, 0, bestiary.kaka[index].descripcion, Color4.Gray);
                }
                else
                {
                    Form1.console.Write(Form1.console.Rows - 3, 0, String.Empty.PadRight(Form1.console.Cols, ' '), Color4.Black);
                    Form1.console.Write(Form1.console.Rows - 2, 0, String.Empty.PadRight(Form1.console.Cols, ' '), Color4.Black);
                }
                
                
            }
        }
        public static void printdisplay()
        {
            Form1.console.Write(0, Form1.console.Cols - 32, "#Status:".PadRight(32,' '), Color4.Khaki);
            Form1.console.Write(1, Form1.console.Cols - 32, ("#Nombre:"+pj.nombre).PadRight(32,' '), Color4.Khaki);
            Form1.console.Write(2, Form1.console.Cols - 32, ("#Level:"+pj.level).PadRight(32,' '), Color4.Khaki);
            Form1.console.Write(3, Form1.console.Cols - 32, ("#Exp:" + pj.exp).PadRight(32, ' '), Color4.Khaki);
            Form1.console.Write(4, Form1.console.Cols - 32, ("#Next Lv:" + pj.next).PadRight(32, ' '), Color4.Khaki);
            Form1.console.Write(5, Form1.console.Cols - 32, ("#HP:" + pj.chp + "/" + pj.mhp).PadRight(32, ' '), Color4.Khaki);
            Form1.console.Write(6, Form1.console.Cols - 32, ("#MP:" + pj.cmp + "/" + pj.mmp).PadRight(32, ' '), Color4.Khaki);
            Form1.console.Write(7, Form1.console.Cols - 32, ("#STR:" + pj.str).PadRight(32, ' '), Color4.Khaki);
            Form1.console.Write(8, Form1.console.Cols - 32, ("#AGI:" + pj.agi).PadRight(32, ' '), Color4.Khaki);
            Form1.console.Write(9, Form1.console.Cols - 32, ("#VIT:" + pj.vit).PadRight(32, ' '), Color4.Khaki);
        }
        public static void putmonster(Enemy enemy)
        {
            
            Form1.console.Write(enemy.y, enemy.x, enemy.simbolo, Color4.Red);
          
        }
        public static void putmonsters(List<Enemy> lista)
        {
            foreach(Enemy monstruo in lista)
            {
                Form1.console.Write(monstruo.y, monstruo.x, " ", Color4.Black, Color4.Black);
                bool aoe = false;
                //if ((pj.y <= monstruo.y + monstruo.areaofsight && monstruo.x+monstruo.areaofsight <= pj.y) || (pj.x >= monstruo.y + monstruo.areaofsight  && monstruo.y+monstruo.areaofsight >= pj.x))
               //calculo si el mob me puede ver
                if((monstruo.y > pj.y  - monstruo.areaofsight && monstruo.y < pj.y + monstruo.areaofsight) && (monstruo.x > pj.x - monstruo.areaofsight && monstruo.x < pj.x + monstruo.areaofsight))
                {
                    aoe = true;
                    if (aoe == true)
                    {
                        Form1.console.Write(Form1.console.Rows - 4, 0, "El monstruo te ve", Color4.Gray);
                        //hacemos que el bicho vaya hacia el jugador
                        Form1.console.Write(monstruo.y, monstruo.x, " ", Color4.Black, Color4.Black);
                        if (monstruo.y > pj.y - monstruo.areaofsight) monstruo.y++;
                        if (monstruo.y < pj.y + monstruo.areaofsight) monstruo.y--;
                        if (monstruo.x < pj.x + monstruo.areaofsight) monstruo.x++;
                        if (monstruo.x < pj.x + monstruo.areaofsight) monstruo.x--;
                        Form1.console.Write(monstruo.y, monstruo.x, monstruo.simbolo, monstruo.forecolor, monstruo.backcolor);
                    }
                }
                else
                {
                    Form1.console.Write(monstruo.y, monstruo.x, monstruo.simbolo, monstruo.forecolor, monstruo.backcolor);
                    Form1.console.Write(Form1.console.Rows - 4, 0, String.Empty.PadRight(Form1.console.Cols, ' '), Color4.Black);
                }
              
            }
        }

    }
}
