using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED.TorresDeHanoi
{
    

    internal class Juego
    {
        internal delegate void alMoverDisco(char Origen, char Destino);
        internal event alMoverDisco DiscoMovido;
        

        private Stack<byte> PosteA;
        private Stack<byte> PosteB;
        private Stack<byte> PosteC;

        private bool EstaIniciado = false;

        /// <summary>
        /// Inicializa el juego
        /// </summary>
        /// <param name="NumDiscos">El número de discos que se usarán (Máx 9)</param>
        public void Iniciar(byte NumDiscos)
        {
            if (NumDiscos==0 || NumDiscos>9)
            {
                throw new ArgumentOutOfRangeException(nameof(NumDiscos));
            }
            PosteA = new Stack<byte>();
            PosteB = new Stack<byte>();
            PosteC = new Stack<byte>();

            //Llena con valores de NumDiscos a 1
            for (byte i = NumDiscos; i > 0 ; i--)
            {
                PosteA.Push(i);
            }

            EstaIniciado=true;
        }

        internal void Mover(char Origen, char Destino)
        {
            string postes = "ABC";
            if (postes.IndexOf(Origen) == -1 || postes.IndexOf(Destino) == -1)
            {
                throw new ArgumentOutOfRangeException("El origen o el destino es incorrecto. (SOLO A, B o C)");
            }
            if (Origen == Destino)
            {
                return;
            }

            Stack<byte> posteOrigen = 
                (Origen == 'A') ? PosteA : 
                    (Origen == 'B') ? PosteB:PosteC ;
            Stack<byte> posteDestino =
                (Destino == 'A') ? PosteA :
                    (Destino == 'B') ? PosteB : PosteC;

            if (posteOrigen.Count==0)
            {
                throw new ArgumentException("El poste origen está vacío.");
            }

            byte valorOrigen = posteOrigen.Peek();
            if (posteDestino.Count>0)
            {
                byte valorDestino = posteDestino.Peek();
                if (valorOrigen>valorDestino)
                {
                    throw new ArgumentException("El disco origen es mayor que el destino");
                }

                posteDestino.Push(posteOrigen.Pop());
                DiscoMovido?.Invoke(Origen, Destino);
            }
            else
            {
                posteDestino.Push(posteOrigen.Pop());
                DiscoMovido?.Invoke(Origen, Destino);
            }
            
        }

        internal void VerPostes()
        {
            Console.WriteLine("Poste A");
            MostrarDatos(PosteA);
            Console.WriteLine("Poste B");
            MostrarDatos(PosteB);
            Console.WriteLine("Poste C");
            MostrarDatos(PosteC);
        }

        private void MostrarDatos(Stack<byte> poste)
        {
            
            foreach (var valor in poste)
            {
                Console.WriteLine($"{valor} ");
            }
            Console.WriteLine();
        }
    }
}
