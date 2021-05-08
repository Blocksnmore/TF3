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
    public bool KeysPressed(Godot.KeyList[] keys)
    {
        foreach (Godot.KeyList key in keys)
        {
            if (Input.IsKeyPressed((int) key)) return true;
        }
        return false;

    }
    
}