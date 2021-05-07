using Godot;
using System;

public class Player : KinematicBody
{
    Main main;
    public Player()
    {
        main = new Sorse().GetInstance();
    }

    public override void _PhysicsProcess(float delta)
    {
        MoveAndSlide(new Sorse().Movement.RunInput(new Vector3()), Vector3.Up);
    }
}