using Godot;

public class Player : KinematicBody
{
    Main Main;
    Spatial CameraSpatial;
    Vector2 StartDraggingPos = new Vector2();
    bool CaptureMouse = true;
    public Player()
    {
        Main = new Sorse().GetInstance();
    }

    public override void _PhysicsProcess(float delta)
    {
        Vector3 Movement = new Sorse().Movement.RunInput(new Vector3());
        MoveAndSlide(Movement, Vector3.Up);
    }
    public override void _Input(InputEvent inputEvent)
    {
        int[] ExitKeys = {
            (int) Godot.KeyList.Escape
        };
        int[] ResetPos = {
            (int) Godot.KeyList.Alt
        };

        if (new Sorse().KeysPressed(ExitKeys) && !inputEvent.IsEcho())
        {
            CaptureMouse = !CaptureMouse;
        }

        if (new Sorse().KeysPressed(ResetPos) && !inputEvent.IsEcho())
        {
            GetNode<Camera>("../Camera").Rotation = new Vector3();
        }

        if (CaptureMouse)
            Input.SetMouseMode(Input.MouseMode.Captured);
        else
            Input.SetMouseMode(Input.MouseMode.Visible);

        if (inputEvent is InputEventMouseMotion inputEventMouseMotion)
        {
            Vector2 Dragged = StartDraggingPos - inputEventMouseMotion.Relative;
            GetNode<KinematicBody>("../Player").RotateY(Dragged.x * 0.005f);
            GetNode<Camera>("../Camera").RotateX(Dragged.y * 0.005f);
            inputEventMouseMotion.Relative = new Vector2();
            StartDraggingPos = new Vector2();
        }
    }
}