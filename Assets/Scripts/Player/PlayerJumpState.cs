using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : PlayerBaseState
{
    public override void EnterState(PlayerController player)
    {
        player.rigidBody.AddForce(new Vector2(0f, 400));
    }

    public override void FixedUpdate(PlayerController player)
    {
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(player.horzMove * player.speed * Time.fixedDeltaTime, player.GetComponent<Rigidbody2D>().velocity.y);
        if (player.horzMove < 0)
            player.GetComponent<SpriteRenderer>().flipX = true;
        if (player.horzMove > 0)
            player.GetComponent<SpriteRenderer>().flipX = false;
    }

    public override void OnCollisionEnter(PlayerController player, Collision2D collision)
    {
        if (collision.gameObject.tag == "Solid")
        {
            player.TransitionToState(player.IdleState);
        }
    }

    public override void Update(PlayerController player)
    {
        player.horzMove = Input.GetAxisRaw("Horizontal");
    }
}
