using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerBaseState
{
    public override void EnterState(PlayerController player)
    {
        // player.GetComponent<Animator>().SetBool("walking", false);
    }

    public override void FixedUpdate(PlayerController player)
    {
        if (player.horzMove != 0)
        {
            Debug.Log(player.horzMove);
            player.TransitionToState(player.WalkingState);
        }
    }

    public override void OnCollisionEnter(PlayerController player, Collision2D collision)
    {
        if(collision.gameObject.tag == "ElevatorSystemManual")
        {
            Debug.Log(collision.gameObject.transform.Find("Elevator").name);
            // Dentro del GameObject ElevatorSystemManual esta el Script ElevatorPlayerController
            // Indicar dentro de ese script cuando esta collision ocurra cambiar el estado a PlayerOver o algo así
            // Y si se encuentra en ese estado que el Player pueda apretar arriba o abajo y mover el ascensor
            // al proximo piso siempre y cuando haya un proximo piso en esa direccion

        }
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
