using Godot;
using System;

public partial class mask_dude : CharacterBody2D
{	
	[Export] Sprite2D sprite = GetNode("Texture");
	[Export] float MoveSpeed = 32.0f;
	Vector2 velocity;

	public override void _Ready()
	{
		velocity = Velocity;  
	}

	public override void _PhysicsProcess(double delta)
	{	
		Move();
		MoveAndSlide();
		sprite.Animate(Velocity);
	}

	public void Move()
	{
		float direction = GetDirection();		
		velocity.X = direction * MoveSpeed;
		Velocity = velocity;
	}
	public float GetDirection()
	{
		return Input.GetAxis("ui_left", "ui_right");
	}
}
