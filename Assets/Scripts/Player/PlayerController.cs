using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;
    public PlayerBaseState currentState;
    public PlayerBaseState CurrentState
    {
        get { return currentState; }
    }
    // STATES
    public readonly PlayerIdleState IdleState = new PlayerIdleState();
    public readonly PlayerWalkingState WalkingState = new PlayerWalkingState();
    public readonly PlayerJumpState JumpState = new PlayerJumpState();

    public Rigidbody2D rigidBody;
    public float speed = 200f;
    public float jumpforce = 200f;
    public float horzMove = 0;
    public float vertMove = 0;
    public bool facingRight = false;
    public bool flipside = false;
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        TransitionToState(IdleState);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentState.OnCollisionEnter(this, collision);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        currentState.FixedUpdate(this);
    }
    void Update()
    {
        currentState.Update(this);
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(bullet);
        }
    }
    public void TransitionToState(PlayerBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
        Debug.Log(currentState);
    }
}
