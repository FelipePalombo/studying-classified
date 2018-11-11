using System;
namespace stuying_classified
{
    class Operador
    {
        public byte Ligado {get; private set;}

        public Operador(string l){
            if(l.Contains("'")){
                this.Ligado = Byte.Parse(l.Substring(1));
                if(this.Ligado == 0){
                    this.Ligado = 1;
                }else{
                    this.Ligado = 0;
                }
            }else if((Byte.Parse(l) < 2) && (Byte.Parse(l) > -1)){
                this.Ligado = Byte.Parse(l);
            }else{
                this.Ligado = 2;
            }
        }
    }
}