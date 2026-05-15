using TMPro;
using UnityEngine;

public class WASDMovement : MonoBehaviour
{
    public float speed = 4f;
    private Rigidbody2D rb2D;
    public float jumpForce;

<<<<<<< HEAD:Anni/Assets/Scripts/WASDMovement.cs
    

=======
>>>>>>> parent of 8a2949f (added car and fixing movement for it):Anni/Assets/WASDMovement.cs
    //score variables
    //keeps track of score
    private int score;
    //displays score
    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rigibody in unity is a component that enables a gameobject
        //it is controlled by the physics engine
        //when it is added to a game object it can use force, gravity, and receive forced
        //and it can interact with OTHER physics enabled objects through collisions
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      
        float horizontalInput = Input.GetAxis("Horizontal");
        //vertical is mapped to w/s and up and down keys
        float verticalInput = Input.GetAxis("Vertical");

<<<<<<< HEAD:Anni/Assets/Scripts/WASDMovement.cs
        
        Vector2 move = new Vector2(horizontalInput, verticalInput);
        rb2D.linearVelocity = move * speed;
=======
        // vector2 (x, y)
        //4 = 2+2
        //accessing the linear velocity of our rigidbody
        //creats a new vector 2 that multiplies input by the speed
        //horizontal/vertical input is either 1 or -1 depending on the key you pressed
        //rb2D.linearVelocity = new Vector2(horizontalInput * speed, verticalInput * speed);

>>>>>>> parent of 8a2949f (added car and fixing movement for it):Anni/Assets/WASDMovement.cs
        //if the player hits space
        if (Input.GetKey(KeyCode.Space))
        {
            //then we are going to jump
            //we are going to keep the velocity on the x and change the y to jump force
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, jumpForce);
        }

<<<<<<< HEAD:Anni/Assets/Scripts/WASDMovement.cs
        //so if we are pressing D
        if (move.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }else if (move.x < 0) //a
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }
        else if(move.y > 0) //w
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }else if (move.y < 0) //s
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

=======
        if (Input.GetKey((KeyCode.A)))
        {
            rb2D.linearVelocity = new Vector2(-1 * speed, 0);
            //rb2D.AddForce(new Vector2(-1 * speed, 0));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //rb2D.linearVelocity = new Vector2(1 * speed, rb2D.linearVelocity.y);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, verticalInput * speed);
            
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb2D.linearVelocity = new Vector2(rb2D.linearVelocity.x, verticalInput * speed);
            
        }

        //can you make a sprinting button?
        //if get key
        //make player faster
>>>>>>> parent of 8a2949f (added car and fixing movement for it):Anni/Assets/WASDMovement.cs
    }

    //then it passes it in to our method
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("I Hit: " + collision.gameObject.name);
       

        if (collision.gameObject.CompareTag("Wall"))
        {
            rb2D.linearVelocity += new Vector2(20, 20);
        }
    }

    //objects that overlap and trigger a behavior 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("I triggered: " + collision.gameObject.name);
        



        /*if (collision.gameObject.CompareTag("Coins"))
        {
            AddScore(1);
            //changes the text to whatever the current score is!
            scoreText.text = "Score" + score.ToString();
            Destroy(collision.gameObject);
        }*/
    }

    private void AddScore(int amt)
    {
        //we are adding the amount to the score to update it
        score += amt;
    }

    

}
