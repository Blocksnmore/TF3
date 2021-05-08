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
        Godot.KeyList[] ExitKeys = {
            Godot.KeyList.Escape
        };
        Godot.KeyList[] ResetPos = {
            Godot.KeyList.Alt
        };
        Camera GameCamera = GetNode<Camera>("../Camera");

        if (new Sorse().KeysPressed(ExitKeys) && !inputEvent.IsEcho())
        {
            CaptureMouse = !CaptureMouse; GD.Print("Test");
        }

        if (new Sorse().KeysPressed(ResetPos) && !inputEvent.IsEcho())
        {
            GameCamera.Rotation = new Vector3();
        }

        if (CaptureMouse)
            Input.SetMouseMode(Input.MouseMode.Captured);
        else
            Input.SetMouseMode(Input.MouseMode.Visible);

        if (inputEvent is InputEventMouseMotion inputEventMouseMotion)
        {
            Vector2 Dragged = StartDraggingPos - inputEventMouseMotion.Relative;
            GetNode<KinematicBody>("../Player").RotateY(Dragged.x * 0.005f);
            GameCamera.RotateX(Dragged.y * 0.005f);

            if (GameCamera.Rotation.x < -1.5f)
            {
                GameCamera.Rotation = new Vector3(-1.5f, 0, 0);
            }

            if (GameCamera.Rotation.x > 1.8f)
            {
                GameCamera.Rotation = new Vector3(1.8f, 0, 0);
            }

            // Don't touch! I'm not exactly sure how this fixed the issue
            // But with this code removed the camera has a stroke.
            inputEventMouseMotion.Relative = new Vector2();
            StartDraggingPos = new Vector2();
        }
    }
}