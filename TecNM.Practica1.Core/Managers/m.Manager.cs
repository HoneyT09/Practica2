using TecNM.Practica1.Core;

namespace TecNM.Practica1.Core{
    public class mManager : ImManager{
        private readonly ImService _service;

        public mManager (ImService service){
            _service = service;
        }

        public m peso(Person person){
            return _service.Calculator(person);
        }
    }
}