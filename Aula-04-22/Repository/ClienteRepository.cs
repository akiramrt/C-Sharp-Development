using Model;

namespace Repository
{
    public class ClienteRepository {
        private List<Cliente> _cliente = new List<Cliente>();

        public void Add (Cliente c) {
            _cliente.Add(c);
        }

        public List<Cliente> GetAll() {
            return _cliente;
        }
    }
}