using UnityEngine;

public class Physics2DDemo : MonoBehaviour
{
    // Rigidbody2D se duoc gan tu Inspector.
    public Rigidbody2D rb;

    void Start()
    {
        // Day object len tren mot luc.
        rb.AddForce(Vector2.up * 5f, ForceMode2D.Impulse);
    }
}
