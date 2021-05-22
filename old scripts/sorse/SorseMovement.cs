using Godot;
using System;

public class SorseMovement
{
    // Settings
    // - Movement
    int speed = 10;
    int gravity = 10;

    Sorsee Sorsee;
    public SorseMovement(Sorsee Sorsee)
    {
        this.Sorsee = Sorsee;
    }

    public Vector3 RunInput(float CamRotation)
    {
        //Vector3 Vector = new Vector3((float)Math.Sin(CamRotation), 0, (float)Math.Cos(CamRotation)) * 10;
        Vector3 Vector = new Vector3();

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
            Vector.z -= speed;
        if (new Sorse().KeysPressed(BackwardKeys))
            Vector.z += speed;
        if (new Sorse().KeysPressed(LeftKeys))
            Vector.x -= speed;
        if (new Sorse().KeysPressed(RightKeys))
            Vector.x += speed;
        if (new Sorse().KeysPressed(JumpKeys))
            Vector.y += gravity * 1;

        return Vector;
    }
}