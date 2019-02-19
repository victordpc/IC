namespace Algoritmia
{
    public class Coordenada
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            Coordenada coordenada = obj as Coordenada;
            return coordenada != null &&
                   X == coordenada.X &&
                   Y == coordenada.Y;
        }

        public override int GetHashCode()
        {
            var hashCode = 1861411795;
            hashCode = hashCode * -1521134295 + X.GetHashCode();
            hashCode = hashCode * -1521134295 + Y.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "X: " + X.ToString() + " Y: " + Y.ToString();
        }
    }

}
