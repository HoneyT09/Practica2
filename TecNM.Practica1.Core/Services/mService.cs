using TecNM.Practica1.Core;

public class mService : ImService{
    public m Calculator(Person person){
        var m = new m();
        m.peso = (float) (person.Peso/9.81*3.711);
        return m;
    }
}