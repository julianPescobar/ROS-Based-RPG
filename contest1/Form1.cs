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
        ConsoleWindow console = new ConsoleWindow(50, 100, "rogue test");
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Form1>().Count() >= 1)
            {
                Application.OpenForms.OfType<Form1>().First().Visible = false;
             
            }
          
          console.Mouse.ButtonDown += new EventHandler<MouseButtonEventArgs>(Mouse_ButtonDown);
            console.Mouse.Move +=new EventHandler<MouseMoveEventArgs>(Mouse_Move);
            pj.x = 0; pj.y = 0;
            // Write to the window at row 6, column 14:
            
            console.Write(pj.x, pj.y, pj.simbol, Color4.White,console.GetBackgroundColor(pj.x,pj.y));
            Random r = new Random();
            
          
            // Finally, update the window until a key is pressed or the window is closed:
            while (console.WindowUpdate())
            {
                if (console.KeyPressed)
               {
                   
                  
                   pj.readmovement(console);

                   //string escribo = "Coords(x:"+pj.x+",y:"+pj.y+") Color Fondo= " + System.Drawing.ColorTranslator.FromHtml("#" + console.GetBackgroundColor(pj.x, pj.y).ToArgb().ToString("X")).Name + " Color Letra = " + System.Drawing.ColorTranslator.FromHtml("#" + console.GetColor(pj.x, pj.y).ToArgb().ToString("X")).Name+" Letra = '"+ console.GetChar(pj.x,pj.y)+"'";
                  

               }

                int mousex = console.Mouse.X / 8;
                int mousey = console.Mouse.Y /12;
                if (mousex >= 0 && mousex < console.Cols - 1 && mousey >= 0 && mousey < console.Rows-1)
                {
                    console.Write(console.Rows - 1, 0, String.Empty.PadRight(console.Cols, ' '), Color4.Black);
                    console.Write(console.Rows - 1, 0, "Mouse Coords(Y" + mousey + ",X" + mousex + ")", Color4.White);
                    console.Write(console.Rows - 2, 0, String.Empty.PadRight(console.Cols, ' '), Color4.Black);
                    console.Write(console.Rows - 2, 0, "Celda:(BColor: " + console.GetBackgroundColor(mousey, mousex).ToArgb().ToString() + " FColor: " + console.GetColor(mousey, mousex).ToArgb().ToString() + " Char: '" + console.GetChar(mousey, mousex) + "'", Color4.Blue);
                }
                /* WindowUpdate() does a few very important things:
                ** It renders the console to the screen;
                ** It checks for input events from the OS, such as keypresses, so that they
                **   can reach the program;
                ** It returns false if the console has been closed, so that the program
                **   can be properly ended. */
            }
            
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
