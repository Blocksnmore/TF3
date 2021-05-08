using Godot;

public class SorseMovement
{
    // Settings
    // - Movement
    int speed = 10;
    int gravity = 10;

    Sorse Sorse;
    public SorseMovement(Sorse Sorse)
    {
        this.Sorse = Sorse;
    }

    public Vector3 RunInput(Vector3 vector)
    {
        Godot.KeyList[] ForwardKeys = {
            Godot.KeyList.Up,
            Godot.KeyList.W
        };
        Godot.KeyList[] BackwardKeys = {
            Godot.KeyList.Down,
            Godot.KeyList.S
        };

        Godot.KeyList[] LeftKeys = {
            Godot.KeyList.Left,
            Godot.KeyList.A
        };
        Godot.KeyList[] RightKeys = {
            Godot.KeyList.Right,
            Godot.KeyList.D
        };

        Godot.KeyList[] JumpKeys = {
            Godot.KeyList.Space
        };

        if (new Sorse().KeysPressed(ForwardKeys))
            vector.z -= speed;
        if (new Sorse().KeysPressed(BackwardKeys))
            vector.z += speed;
        if (new Sorse().KeysPressed(LeftKeys))
            vector.x -= speed;
        if (new Sorse().KeysPressed(RightKeys))
            vector.x += speed;
        if (new Sorse().KeysPressed(JumpKeys))
            vector.y += gravity * -1;

        return vector;
    }
}