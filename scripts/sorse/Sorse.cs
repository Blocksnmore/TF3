using Godot;

public class Sorse
{
    SorseClassTypes.InstanceData ClassTypes = new SorseClassTypes.InstanceData();

    public Sorse(SorseClassTypes.InstanceData Classes = null)
    {
        if (Classes.Menu != null) this.ClassTypes.Menu = Classes.Menu;
        if (Classes.Player != null) this.ClassTypes.Player = Classes.Player;

        this.ClassTypes.Sorse3DMovement = new Sorse3DMovement(this);
    }

    // Returns Main instance
    public SorseClassTypes.InstanceData GetInstances()
    {
        return ClassTypes;
    }

    // Checks if specific key is pressed
    public bool KeysPressed(Godot.KeyList[] keys)
    {
        foreach (Godot.KeyList key in keys)
        {
            if (Input.IsKeyPressed((int)key)) return true;
        }
        return false;

    }

}