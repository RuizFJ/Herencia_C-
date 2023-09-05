namespace Modelo
{
    public class Venta
    {
        public string Cliente { get; set; }
        public string Ruc { get; set; }

        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }

        //METODO 

        public double AsignaPrecio()
        {
            switch (Producto)
            {
                case "Lavadora": return 1500;
                case "Refirgeradora": return 3500;
                case "Licuadora": return 500;
                case "Extractora": return 150;
                case "Radiograbadora": return 750;
                case "DVD": return 100;
                case "BlueRay": return 250;
            }


            return 0;


        }
        //Metodo que calcula el subtotal

        public double CalculaSubtotal()
        {
            return AsignaPrecio() * Cantidad;
        }

    }
}