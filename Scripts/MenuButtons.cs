using Godot;
using System;

public class MenuButtons : VBoxContainer
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

      // Called every frame. 'delta' is the elapsed time since the previous frame.
      public override void _Process(float delta)
      {
          
      }

    public void _on_startButton_pressed()
    {
        GetTree().ChangeScene("res://Scenes/Level01.tscn");
    }
    public void _on_exitButton_pressed()
    {
        GetTree().Quit();
    }
}