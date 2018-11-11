using System;
using System.IO;

namespace stuying_classified
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciado");
            Operador A;
            Operador B;
            Operacao AOp;
            string[] c = Console.ReadLine().Split(',');
            A = new Operador(c[0]);
            B = new Operador(c[1]);
            string O = c[2];
            while(A.Ligado < 2 || B.Ligado < 2){
                AOp = new Operacao(A, B, O);
                Console.WriteLine(AOp.ResultadoFinal);
                string[] b = Console.ReadLine().Split(',');
                A = new Operador(b[0]);
                B = new Operador(b[1]);
                O = b[2];
            }
        }
    }
}    
    

