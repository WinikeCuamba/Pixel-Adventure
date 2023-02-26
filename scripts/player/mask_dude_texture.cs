using Godot;
using System;

public partial class mask_dude_texture : Sprite2D
{

	public override void _Process(double delta)
	{
	}
	public void Animate(Vector2 velocity)
	{
		GD.Print(velocity);
	}
}

