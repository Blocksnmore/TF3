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
        int[] ForwardKeys = {
            (int) Godot.KeyList.Up,
            (int) Godot.KeyList.W
        };
        int[] BackwardKeys = {
            (int) Godot.KeyList.Down,
            (int) Godot.KeyList.S
        };

        int[] LeftKeys = {
            (int) Godot.KeyList.Left,
            (int) Godot.KeyList.A
        };
        int[] RightKeys = {
            (int) Godot.KeyList.Right,
            (int) Godot.KeyList.D
        };

        int[] JumpKeys = {
            (int) Godot.KeyList.Space
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