using Godot; // at least it's not unity

public class Main : Spatial // im not even going to pretend i know what this means
{
    Classes Classes = new Classes(); // classes classes classes classes classes
    public override void _Ready() // you're not _Ready() for this bad pun
    {
        GD.Print("Team Fortress 3"); // valve's lawyers approve
        GD.Print("Created by Blocks_n_more"); // ha ha not anymore -zanac
    }
    public void LoadFiles() // gee i wonder what this does
    {
        new Sorse(this); // achieved with sorse
    }
}
