using UnityEngine;
using System.Collections;

public class AnimatorController : MonoBehaviour
{
    public float speed = 1f;

    private Animator animator;
    private Rigidbody2D rb;

    public Transform cursor;
    public float number; 
    public bool facingRight = true;

    public void Start()
    {
        this.animator = this.GetComponent<Animator>();
        this.rb = this.GetComponent<Rigidbody2D>();
    }

    public void Update()
    {

        //SONIC MOVE LEFT
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            FlipLeft();

            animator.Play("Run");
            transform.Translate(Vector2.right * -2f * Time.deltaTime);
        }

        //SONIC MOVE RIGHT
        if (Input.GetKey(KeyCode.RightArrow))
        {
            FlipRight();
            animator.Play("Run");
            transform.Translate(Vector2.right * 2f * Time.deltaTime);
        }


        //SONIC SPECIAL JUMP
        if (Input.GetKey(KeyCode.Space))
        {
            animator.Play("Idle");
            transform.Translate(Vector2.up * 3.5f * Time.deltaTime);
        }

        //QUIT THE GAME
        if(Input.GetKey("escape"))
        {
            Debug.Log("Quit!");
            Application.Quit();
        }

    }

    public void FlipLeft()
    {
        facingRight = false;

        Vector3 theScale = transform.localScale;
        theScale.x = -1;
        transform.localScale = theScale;
    }

    public void FlipRight()
    {
        facingRight = true;

        Vector3 theScale = transform.localScale;
        theScale.x = 1;
        transform.localScale = theScale;
    }
}