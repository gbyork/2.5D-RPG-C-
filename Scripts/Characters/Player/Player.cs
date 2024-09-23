using Godot;
using System;
public partial class Player : CharacterBody3D
{
    [ExportGroup("Required Nodes")]
    [Export] public AnimationPlayer AnimationPlayerNode {get; private set;}
    [Export] public Sprite3D SpriteNode {get; private set;}
    [Export] public StateMachine StateMachineNode {get; private set;}
    public Vector2 direction = new();

    public override void _Input(InputEvent @event)
    {
        direction = Input.GetVector(
            GameConstants.INPUT_LEFT,GameConstants.INPUT_RIGHT,
            GameConstants.INPUT_FORWARD,GameConstants.INPUT_BACK
        );
    }
    public void Flip()
    {
        bool isNotMovingHorizontally = Velocity.X == 0;

        if (isNotMovingHorizontally) {return;}

        bool isMovingLeft = Velocity.X < 0;
        SpriteNode.FlipH = isMovingLeft;
    }
}
