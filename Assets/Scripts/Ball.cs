using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float bounceForce;
    bool gameStarted;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            if (Input.anyKeyDown)
            {
                StartBounce();
                gameStarted = true;
                GameManager.instance.gameStart();

            }
        }

    }

    void StartBounce()
    {
        Vector2 vector = new Vector2(Random.Range(-1, 1), 1);
        rb.AddForce(vector * bounceForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FallCheck"))
        {
            GameManager.instance.Restart();
        }
        else if (collision.gameObject.CompareTag("Paddle"))
        {
            GameManager.instance.ScoreUp();
        }
    }

}