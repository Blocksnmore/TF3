using Godot;

public class Sorse
{
    public Menu Menu;
    public Player Player;
    public Sorse3DMovement Sorse3DMovement;

    public Sorse()
    {
        this.Sorse3DMovement = new Sorse3DMovement(this);
    }

    public class Instances {
        public void Menu(Menu Menu){
            new Sorse().Menu = Menu;
        }
        public void Player(Player Player){
            new Sorse().Player = Player;
        }
    }

    // Returns Main instance
    public SorseClassTypes.InstanceData GetInstances()
    {
        SorseClassTypes.InstanceData ClassTypes = new SorseClassTypes.InstanceData();
        ClassTypes.Menu = Menu;
        ClassTypes.Player = Player;
        ClassTypes.Sorse3DMovement = Sorse3DMovement;
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
    public class Movement3D{
        
    }
}