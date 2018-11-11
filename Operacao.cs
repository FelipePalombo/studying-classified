using System;
namespace stuying_classified
{
    class Operacao
    {
        public int ResultadoFinal {get; private set;}
        public Operador A {get; private set;}
        public Operador B {get; private set;}
        public string NomeOperacao {get; private set;}

        public Operacao(Operador A, Operador B, string nop){
            this.A = A;
            this.B = B;
            this.NomeOperacao = nop;
            procStarter();
        } 

        private int negacao(int x){
            return (x == 0 ? 1 : 0);
        }

        private void procStarter(){
            if(string.Equals("AND", NomeOperacao.Substring(NomeOperacao.Length-3, 3))){
                ResultadoFinal = getAnd(this.A.Ligado,this.B.Ligado);
            }else{
                ResultadoFinal = getOr(this.A.Ligado,this.B.Ligado);
            }
            if(NomeOperacao.Contains("'")){
                ResultadoFinal = negacao(ResultadoFinal);
            } 
        }

        

        private int getAnd(byte A, byte B){
            int x = -1;
        	if(A==1 && B==1){
                x = 1;
            }else{
                x = 0;
            }
            return x;
        }

        private int getOr(byte A, byte B){
            int x = -1;
        	if(A==0 && B==0){
                x = 0;
            }else if(A==1 || B==1){
                x = 1;
            }
            return x;
        }
    }
}