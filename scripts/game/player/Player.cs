using Godot;
using System;

public class Player : KinematicBody
{
    public override void _Ready()
    {
        new Sorse.Instances().Player(this);
    }

    public override void _PhysicsProcess(float delta)
    {
        Sorse3DMovement Sorse3DMovement = new Sorse().GetInstances().Sorse3DMovement;
        Vector3 Position = Sorse3DMovement.PlayerMovement(this);
        //Position.y -= Sorse3DMovement.Gravity * delta;
        MoveAndCollide(Position, false);
        //MoveAndSlide(Position, Vector3.Up);
    }
}