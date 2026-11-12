using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float speed = 5f; 

    private Rigidbody2D rb;

    private bool isGrounded = false;

    public MenuScene menu;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //Vai reconhecer o movimento horizontal

        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y); //Vai aplicar a velocidade horizontal ao Rigidbody2D

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse); //Vai aplicar uma força vertical ao Rigidbody2D
        }

    }

    void OnCollisionEnter2D( Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; //Vai reconhecer quando o jogador estiver no chão
        }

        if (collision.gameObject.CompareTag("Dano"))
        {
          menu.MostrarGameOver(); //Vai mostrar o painel de Game Over quando o jogador colidir com um objeto com a tag "Dano"
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false; //Vai reconhecer quando o jogador não estiver no chão
        }
    }
}