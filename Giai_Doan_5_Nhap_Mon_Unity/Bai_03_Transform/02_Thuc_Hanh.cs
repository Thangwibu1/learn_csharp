using UnityEngine;

public class TransformDemo : MonoBehaviour
{
    // Toc do di chuyen.
    public float moveSpeed = 3f;

    // Update chay moi frame.
    void Update()
    {
        // Di chuyen object sang phai.
        transform.position += Vector3.right * moveSpeed * Time.deltaTime;
    }
}
