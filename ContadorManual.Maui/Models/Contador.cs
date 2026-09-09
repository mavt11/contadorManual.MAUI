namespace ContadorManual.Maui.Models
{
 public class Contador
    {
        private int _conteo;
        public int _Conteo => _conteo;

        public Contador ()
            {
              _conteo = 0;
            }
        public void Contar()
        {
            _conteo++;
        }
        
        public void Reiniciar()
        {
            _conteo= 0;
        }

    }
}
