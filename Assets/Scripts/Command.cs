using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command 
{
    protected GameObject obj;

    public Command(GameObject obj)
    {
        this.obj = obj;
    }
    public virtual void Execute() { }
}


public class MoveCommand : Command
{
    Movement objMovement;
    Animation objAnimation;
    Vector3 direction;
    float speed;

    public MoveCommand(GameObject obj, Vector3 direction, float speed) : base(obj)
    {
        objMovement = obj.GetComponent<Movement>();
        objAnimation = obj.GetComponent<Animation>();
        this.direction = direction;
        this.speed = speed;
    }

    public override void Execute()
    {
        objMovement.Move(direction, speed);
        objAnimation.Walk(direction);
    }
}



