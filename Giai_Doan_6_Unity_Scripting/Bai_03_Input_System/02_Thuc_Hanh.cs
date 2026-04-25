using UnityEngine;

public class InputDemo : MonoBehaviour
{
    // Toc do di chuyen.
    public float moveSpeed = 5f;

    void Update()
    {
        // Lay input ngang.
        float horizontal = Input.GetAxisRaw("Horizontal");

        // Di chuyen object.
        transform.position += Vector3.right * horizontal * moveSpeed * Time.deltaTime;
    }
}
