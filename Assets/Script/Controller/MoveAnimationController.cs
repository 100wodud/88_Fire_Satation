using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimationController : MoveAnimation
{
    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Animation;
    }

    // Update is called once per frame
    public void Animation(Vector2 direction)
    {
        animator.SetBool("IsMove",direction.magnitude > 0f);
    }
}
