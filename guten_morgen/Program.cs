using System;

namespace guten_morgen
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] color = {"lmao", "dab", "gluten"};
            int[] cool = {1, 2, 3};
            float[] thicc = {0.1f, 0.2f, 47f};
            
            Sak[] saker = new Sak[3];


            for (int i = 0; i < saker.Length; i++) {
                saker[i] = new Sak() {coolnes = cool[i], largenes = thicc[i], colornes = color[i]};
        
                System.Console.WriteLine(saker[i].coolnes + " " + saker[i].largenes + " " + saker[i].colornes);   

            }


            Console.ReadLine();
        }
    }
}
