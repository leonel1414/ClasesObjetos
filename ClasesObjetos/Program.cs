
Puerta door = new Puerta(150,200,"rojo",false);
door.MostrarEstado();
class Puerta {
    int ancho;
    int alto;
    string color;
    bool abierto;

    //Constructor
    public Puerta(int ancho, int alto, string color, bool abierto) {
        this.ancho = ancho;
        this.alto = alto;
        this.color = color;
        this.abierto = abierto;
    }

   

    public void MostrarEstado() 
    {
        Console.WriteLine("Ancho: " + ancho);
        Console.WriteLine("Alto: " + alto);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Abierta ?: " + abierto);
    }
}
