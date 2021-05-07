using Godot;

public class Main : Spatial
{
    Classes Classes = new Classes();
    public override void _Ready()
    {
        GD.Print("Team Fortress 3");
        GD.Print("Created by Blocks_n_more");
    }
    public void LoadFiles()
    {
        new Sorse(this);
    }
}
