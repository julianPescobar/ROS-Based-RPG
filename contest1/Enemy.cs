using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Graphics;

 namespace contest1
{
    public class Enemy 
    {
       
        public  string simbolo { get; set; }
        public  int x{ get; set; }
        public  int y{ get; set; }
        public  int hp{ get; set; } 
        public  int exp { get; set; } 
        public  int str{ get; set; } 
        public  int agi { get; set; }
        public string name { get; set; }
        public Color4 forecolor { get; set; }
        public Color4 backcolor { get; set; }
        public string descripcion { get; set; }
        public string motto1 { get; set; }
        public string motto2 { get; set; }
        public string motto3 { get; set; }
        public int areaofsight { get; set; }
     
    }
      

}

