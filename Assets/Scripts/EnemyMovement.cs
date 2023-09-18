using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class EnemyMovement : MonoBehaviour
{

    [SerializeField] private float velocity = 2f;
    private float direction;
    private bool goingToLeft = true;
    private bool isFlipped = true;
    private bool isWalking = true;
    SpriteRenderer spriteRenderer;


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (Random.Range(0, 2) == 1)
        {
            GoToLeft();
            spriteRenderer.flipX = true;
        }
        else
        {
            GoToRight();
        }
    }

    void FixedUpdate()
    {
        if (isWalking)
            Walk();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("TRIGGER ENTERED");
        if (other.gameObject.CompareTag("LeftWall"))
        {
            GoToRight();
        }
        else if (other.gameObject.CompareTag("RightWall"))
        {
            GoToLeft();
        }
    }

    public void StopWalking() => isWalking = false;

    void Walk()
    {
        if (goingToLeft)
        {
            transform.position = new Vector3(transform.position.x - velocity * Time.deltaTime, transform.position.y, 0);

        }
        else
        {
            transform.position = new Vector3(transform.position.x + velocity * Time.deltaTime, transform.position.y, 0);
        }
    }

    void GoToLeft()
    {
        direction = -transform.localScale.x;
        goingToLeft = true;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
    void GoToRight()
    {
        direction = transform.localScale.x;
        goingToLeft = false;
        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }


}
