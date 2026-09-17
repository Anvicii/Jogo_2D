using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //Vai reconhecer o movimento horizontal

        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y); //Vai aplicar a velocidade horizontal ao Rigidbody2D

        if (Input.GetKeyDown(KeyCode.Space))
        {
          rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse); //Vai aplicar uma força vertical ao Rigidbody2D
        }
    
    }
}
