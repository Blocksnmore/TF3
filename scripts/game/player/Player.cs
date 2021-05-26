using Godot;
using System;

public class Player : KinematicBody
{
    Vector2 StartDraggingPos = new Vector2();


    public override void _Ready()
    {
        new Sorse.Instances().Player(this);
        Input.SetMouseMode(Input.MouseMode.Captured);
    }

    public override void _PhysicsProcess(float delta)
    {
        Sorse3DMovement Sorse3DMovement = new Sorse().GetInstances().Sorse3DMovement;
        Vector3 Position = Sorse3DMovement.PlayerMovement(this);
        // TODO: Fix this code. Why are the docs so bad :notlikethis:
        //Vector3 RotatedPos = Position.Rotated(Position.Normalized(), GetNode<KinematicBody>("../Player").Rotation.y);
        MoveAndSlide(Position, Vector3.Up);
    }

    public override void _Input(InputEvent inputEvent)
    {
        Camera Camera = GetNode<Camera>("RotatePoint/Camera");

        KeyList[] ExitKeys = {
            KeyList.Escape,
        };
        KeyList[] ResetKeys = {
            KeyList.Alt
        };

        if (new Sorse().KeysPressed(ExitKeys))
            GetTree().Quit();

        if (new Sorse().KeysPressed(ResetKeys) && !inputEvent.IsEcho())
        {
            Camera.Rotation = new Vector3();
            Camera.RotateY(-90);
        }

        if (inputEvent is InputEventMouseMotion inputEventMouseMotion)
        {
            Vector2 DraggedAmount = new Vector2() - inputEventMouseMotion.Relative;
            GetNode<KinematicBody>("../Player").RotateY(DraggedAmount.x * 0.005f);
            Camera.RotateX(DraggedAmount.y * 0.005f);

            if (Camera.Rotation.x < -1.5f)
                Camera.Rotation = new Vector3(-1.5f, 0, 0);

            if (Camera.Rotation.x > 1.8f)
                Camera.Rotation = new Vector3(1.8f, 0, 0);

            // Blocks says: Don't remove these 2 lines of code! 
            // With them removed the camera starts having a seizure 
            inputEventMouseMotion.Relative = new Vector2();
            StartDraggingPos = new Vector2();
        }
    }
}