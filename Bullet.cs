using Godot;
using System;

public partial class Bullet : CharacterBody2D
{
	public Vector2 pos;
	public float rota;
	public float dir;
	public int speed = 2000;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GlobalPosition = pos;
		GlobalRotation = rota;
	}

	public override void _PhysicsProcess(double delta)
	{
		Velocity = new Vector2(speed, 0).Rotated(dir);
		MoveAndSlide();
    }

}
