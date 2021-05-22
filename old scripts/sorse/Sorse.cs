using Godot;
using System.Linq;

public class Sorsee
{
    TF3 Main;
    public SorseMovement Movement;
    public Sorsee(TF3 Main = null)
    {
        if (Main != null)
        {
            this.Main = Main;
        }
        Movement = new SorseMovement(this);
    }

    // Returns Main instance
    public TF3 GetInstance()
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