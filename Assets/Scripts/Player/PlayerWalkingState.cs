using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkingState : PlayerBaseState
{
    public override void EnterState(PlayerController player)
    {
        // player.GetComponent<Animator>().SetBool("walking", true);
    }

    public override void FixedUpdate(PlayerController player)
    {
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.horzMove * player.speed * Time.fixedDeltaTime, player.GetComponent<Rigidbody2D>().velocity.y);
        if (player.horzMove < 0)
            player.transform.rotation = new Quaternion(0f, 180f, 0f, 0f);
        if (player.horzMove > 0)
            player.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
        if (player.horzMove == 0)
            player.TransitionToState(player.IdleState);
        
    }

    public override void OnCollisionEnter(PlayerController player, Collision2D collision)
    {
        Debug.Log("PLAYER: " + collision.gameObject.name);

        
    }

    public override void Update(PlayerController player)
    {
        player.horzMove = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump"))
        {
            player.TransitionToState(player.JumpState);
        }
    }
}
