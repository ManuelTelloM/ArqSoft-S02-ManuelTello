namespace Ahorcado
{
    public class PalabrasEnMemoria : IRepositorioPalabras
    {
        private readonly Dictionary<string, List<string>> _categorias = new()
        {
            ["Arquitectura"] = new() { "arquitectura", "componente", "descomposicion", "dependencia", "acoplamiento" },
            ["POO"] = new() { "polimorfismo", "encapsulamiento", "herencia", "abstraccion", "clase" },
            [".NET"] = new() { "ensamblado", "namespace", "interfaz", "delegado", "middleware" }
        };

        private readonly string _categoria;

        public PalabrasEnMemoria(string categoria)
        {
            _categoria = categoria;
        }

        public string ObtenerPalabraAleatoria()
        {
            var lista = _categorias[_categoria];
            var random = new Random();
            return lista[random.Next(lista.Count)];
        }
    }
}