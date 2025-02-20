using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;
    public LayerMask bounceLayers;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = new Vector3(0, 0, speed); // Initial movement
    }

    void OnCollisionEnter(Collision collision)
    {
        if (((1 << collision.gameObject.layer) & bounceLayers) != 0)
        {
            Vector3 reflectDirection = Vector3.Reflect(rb.linearVelocity, collision.contacts[0].normal);
            rb.linearVelocity = reflectDirection.normalized * speed;
        }
    }
}
