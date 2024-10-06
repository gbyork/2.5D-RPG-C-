using Godot;
using System;

public partial class ReturnState : EnemyState
{
    private Vector3 destination;

    public override void _Ready()
    {
        base._Ready();
        Vector3 localPosition = characterNode.PathNode.Curve.GetPointPosition(0);
        Vector3 globalPosition = characterNode.PathNode.GlobalPosition;
        destination = localPosition + globalPosition;
    }
    protected override void EnterState()
    {
        characterNode.AnimationPlayerNode.Play(GameConstants.ANIM_MOVE); 


        characterNode.GlobalPosition = destination;
    }
}
