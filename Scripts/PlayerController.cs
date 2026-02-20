using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    [SerializeField] private float playerSpeed = 1.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        float dirY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(dirX, dirY).normalized;
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = playerDirection * playerSpeed;
    }
}
