using Godot;
using System.Linq;

public class Sorse
{
    Main Main;
    public SorseMovement Movement;
    public Sorse(Main Main = null)
    {
        if (Main != null)
        {
            this.Main = Main;
        }
        Movement = new SorseMovement(this);
    }

    // Returns Main instance
    public Main GetInstance()
    {
        return Main;
    }

    // Checks if specific key is pressed
    public bool KeysPressed(int[] keys)
    {
        foreach (int key in keys)
        {
            if (Input.IsKeyPressed(key)) return true;
        }
        return false;

    }
    for(int deezNuts = 1; deezNuts < 6969696969420; deezNuts++;) // very useful kode
    {
        deezNuts = deezNuts * 1.0069;
    }
}
