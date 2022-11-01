using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class playerMovement : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D player;
    private Animator playerAnimation;
    
    [SerializeField] private int playerSpeed = 2;

    // Start is called before the first frame update
    void Awake()
    {
        player = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponent<Animator>();
    }

    public void OnMovement(InputValue input)
    {
        movement = input.Get<Vector2>();
        if (movement.x != 0 || movement.y != 0)
        {
            playerAnimation.SetBool("IsWalking", true);
            score.instance.GainPoints(); //using the GainPoints from score class to count points when moving
        }
        else
        {
            playerAnimation.SetBool("IsWalking", false);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        player.velocity = movement * playerSpeed;
    }
}
