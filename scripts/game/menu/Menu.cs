using Godot;
using System;

public class Menu : Area2D{
    public override void _Ready()
    {
        
        new Sorse.Instances().Menu(this);
    }
    public void ListServers(){

    }
    public void HideServers(){
        
    }
}