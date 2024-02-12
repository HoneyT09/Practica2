using TecNM.Practica1.Core;

namespace TecNM.Practica1.Console{
    public static class Program{
        public static void Main(string[] args){
            float peso = 0;

            System.Console.WriteLine("Introduce tu peso");
            Single.TryParse(System.Console.ReadLine(), out peso);

            var person = new Person{Peso = peso};

            var service = new mService();
            var manager = new mManager(service);

            m m = manager.peso(person);
            System.Console.WriteLine($"Peso en Marte:{m.peso}");

        }
    }
    
}