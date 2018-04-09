using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SunshineConsole;
using OpenTK.Graphics;
using OpenTK.Input;
using OpenTK;


namespace contest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Visible = false;
        }
        public static ConsoleWindow console = new ConsoleWindow(50, 100, "rogue test");
       
        private void Form1_Load(object sender, EventArgs e)
        {
            bestiary.start();
            pj.x = 0; pj.y = 0;
            pj.nombre = "Arturito";
            pj.level = 1;
            pj.exp = 0;
            pj.next = 100;
            pj.chp = 10; pj.mhp = 10;
            pj.cmp = 2; pj.mmp = 2;
            pj.str = 1;
            pj.agi = 2;
            pj.vit = 2;
            
            //event handlers
            List<Enemy> floor1 = new List<Enemy>();
            floor1.Add(bestiary.slime);
            Game.putmonsters(floor1);
          console.Mouse.ButtonDown += new EventHandler<MouseButtonEventArgs>(Mouse_ButtonDown);
            console.Mouse.Move +=new EventHandler<MouseMoveEventArgs>(Mouse_Move);
         
           
            console.Write(pj.x, pj.y, pj.simbol, Color4.White,console.GetBackgroundColor(pj.x,pj.y));
            Random r = new Random();

           
            // Finally, update the window until a key is pressed or the window is closed:
            while (console.WindowUpdate())
            {
                if (Form1.console.KeyPressed)
                {

                    pj.readmovement(Form1.console);

                    Game.putmonsters(floor1);
                    //string escribo = "Coords(x:"+pj.x+",y:"+pj.y+") Color Fondo= " + System.Drawing.ColorTranslator.FromHtml("#" + console.GetBackgroundColor(pj.x, pj.y).ToArgb().ToString("X")).Name + " Color Letra = " + System.Drawing.ColorTranslator.FromHtml("#" + console.GetColor(pj.x, pj.y).ToArgb().ToString("X")).Name+" Letra = '"+ console.GetChar(pj.x,pj.y)+"'";
                    pj.getcharstatus();

                }
                Game.update();
             
            }  
                /* WindowUpdate() does a few very important things:
                ** It renders the console to the screen;
                ** It checks for input events from the OS, such as keypresses, so that they
                **   can reach the program;
                ** It returns false if the console has been closed, so that the program
                **   can be properly ended. */
        }
        public void draw()
        {
            int mousex = console.Mouse.X / 8;
            int mousey = console.Mouse.Y / 12;
            Random r = new Random();
            int num = r.Next(0, 1000); // Zero to 25
            console.Write(mousey, mousex, " ", Color4.White, new Color4(Convert.ToByte(r.Next(255)), Convert.ToByte(r.Next(255)), Convert.ToByte(r.Next(255)), Convert.ToByte(r.Next(255))));
                
        }
        public void Mouse_ButtonDown(object sender, MouseButtonEventArgs mb)
        {
            if ( mb.IsPressed == true &&  mb.Button == MouseButton.Left)
            {
                draw();
            }
            if (mb.IsPressed == true && mb.Button == MouseButton.Right)
            {
                int mousex = console.Mouse.X / 8;
                int mousey = console.Mouse.Y / 12;
                Random r = new Random();
                int num = r.Next(0, 1000); // Zero to 25
                console.Write(mousey, mousex, " ", Color4.Black);

            }
        }
        public void Mouse_Move(object sender, MouseMoveEventArgs mm)
        {
            if (mm.Mouse.IsButtonDown(MouseButton.Left))
            {
                draw();
            }
            if (mm.Mouse.IsButtonDown(MouseButton.Right))
            {
                int mousex = console.Mouse.X / 8;
                int mousey = console.Mouse.Y / 12;
                
                console.Write(mousey, mousex, " ", Color4.White, Color4.Black);

            }
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
            Environment.Exit(0);
        }
    }
}
