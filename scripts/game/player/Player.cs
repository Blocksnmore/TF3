using Godot;
using System;

public class Player : Spatial{
    public override void _Ready()
    {
        SorseClassTypes.InstanceData Classtypes = new SorseClassTypes.InstanceData();
        Classtypes.Player = this;
        new Sorse(Classtypes);
    }
}