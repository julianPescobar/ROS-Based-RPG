using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK.Graphics;

namespace contest1
{
    public class bestiary
    {
        public static Enemy rat = new Enemy()
        {
            name = "una Rata",
            simbolo = "r",
            x = 1,
            y = 1,
            agi = 1,
            str = 1,
            exp = 1,
            hp = 1,
            forecolor = Color4.RosyBrown,
            backcolor = Color4.Black,
            descripcion = "Una rata comun y corriente, del tamano de un gato.",
            motto1 = "Hiss!!!",
            motto2 = "Cuich!",
            motto3 = "*Gruñidos*",
            areaofsight = 4
        };
        
        public static Enemy kobold = new Enemy()
        {
            name = "un Kobold",
            simbolo = "k",
            x = 2,
            y = 2,
            agi = 5,
            str = 3,
            exp = 16,
            hp = 10,
            forecolor = Color4.Brown,
            backcolor = Color4.Black,
            descripcion = "Un kobold de estatura mediana, tiene forma humanoide.",
            motto1 = "Eh vos amigo! No tenes un pesito para la birra?",
            motto2 = "Eh amigo! Te estoy hablando gato! Dame todo gil o te corto.",
            motto3 = "Ahora vas a caer preso por matar a un ladron...",
            areaofsight = 6
        };
        public static Enemy nochero = new Enemy()
        {
            name = "Nochero, Dios Man-Horse",
            simbolo = "N",
            x = 3,
            y = 3,
            agi = 5,
            str = 3,
            exp = 832,
            hp = 1035,
            forecolor = Color4.Brown,
            backcolor = Color4.Blue,
            descripcion = "El dios Mitad hombre mitad caballo, esta completamente desnudo y en una furia enceguecedora.",
            motto1 = "LLEGO EL PIZZERO HIJO DE PUTA!!! ABRI HIJO DE PUTA QUE LLEGO LA PIZZA!!",
            motto2 = "COME METAL HIJO DE PUTAAAAA!!!!!!",
            motto3 = "NOOOOO LA CONCHA DE TU MADRE HIJO DE PUTA!!!!",
            areaofsight = 20
        };

        public static Enemy slime = new Enemy()
        {
            name = "un Slime",
            simbolo = "s",
            x = 20,
            y = 20,
            agi = 2,
            str = 4,
            exp = 10,
            hp = 25,
            forecolor = Color4.Green,
            backcolor = Color4.Black,
            descripcion = "un slime gelatinoso, su textura es similar a la del fluido nasal",
            motto1 = "*wobble*",
            motto2 = "Kyu?",
            motto3 = "Wgr!",
            areaofsight = 4
        };


        public static List<Enemy> kaka = new List<Enemy>();
        public static void start()
        {
            kaka.Add(rat);
            kaka.Add(kobold);
            kaka.Add(nochero);
            kaka.Add(slime);
        }
        
        
    }
}
