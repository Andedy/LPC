namespace aula02_exe_oo
{
    public class Gerente
    {
        private double salario=2000;
        public void aumento(){
        this.salario=this.salario+((this.salario*10)/100);
        }

        public void aumento(double valor){
        this.salario=this.salario+((this.salario*valor)/100);
        }

    }
}