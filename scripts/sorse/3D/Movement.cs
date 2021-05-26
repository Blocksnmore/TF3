using Godot;
using System;

public class Sorse3DMovement
{
    // Settings
    // - Movement
    public float Gravity = 10;
    public float Speed = 5f;

    Sorse Sorse;
    public Sorse3DMovement(Sorse Sorse)
    {
        this.Sorse = Sorse;
    }

    public Vector3 PlayerMovement(KinematicBody Player)
    {
        Vector3 Position = new Vector3();

        KeyList[] JumpKeys = {
            KeyList.Space,
        };
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

        if (Sorse.KeysPressed(JumpKeys) && Player.IsOnFloor())
            Position.y += Gravity;


        if (Sorse.KeysPressed(ForwardKeys))
            Position.x += Speed;
        if (Sorse.KeysPressed(BackwardKeys))
            Position.x -= Speed;
        if (Sorse.KeysPressed(LeftKeys))
            Position.z -= Speed;
        if (Sorse.KeysPressed(RightKeys))
            Position.z += Speed;

        return Position;
    }
}