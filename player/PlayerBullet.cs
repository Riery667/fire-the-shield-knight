using Godot;
using System;

public partial class Player : Area2D
{
	PackedScene preLoadBullet = GD.Load<PackedScene>("res://bullet.tscn");


	private void Fire()
	{
		Bullet bullet = (Bullet)preLoadBullet.Instantiate();
		bullet.dir = Rotation;
		bullet.pos = GlobalPosition;
		bullet.rota = GlobalRotation;
		GetParent().AddChild(bullet);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _PhysicsProcess(double delta)
	{
		LookAt(GetGlobalMousePosition());
		if (Input.IsActionJustPressed("LB"))
		{
			Fire();
		}
		
	}
}
