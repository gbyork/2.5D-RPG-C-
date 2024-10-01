using Godot;
using System;
public partial class Player : Character
{
    public override void _Input(InputEvent @event)
    {
        direction = Input.GetVector(
            GameConstants.INPUT_LEFT,GameConstants.INPUT_RIGHT,
            GameConstants.INPUT_FORWARD,GameConstants.INPUT_BACK
        );
    }
}
