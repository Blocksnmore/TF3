using Godot;
using System;

public class Menu : Area2D{
    public override void _Ready()
    {
        SorseClassTypes.InstanceData Classtypes = new SorseClassTypes.InstanceData();
        Classtypes.Menu = this;
        new Sorse(Classtypes);
    }
    public void ListServers(){

    }
    public void HideServers(){
        
    }
}