using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float hitForce = 10f;
    public Rigidbody ballRigidbody;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        MovePlayer();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HitBall();
        }
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float moveZ = Input.GetAxis("Vertical"); // W/S or Up/Down
        Vector3 moveDirection = new Vector3(moveX, 0, moveZ) * moveSpeed * Time.deltaTime;
        rb.MovePosition(transform.position + moveDirection);
    }

    void HitBall()
    {
        if (ballRigidbody != null)
        {
            Vector3 hitDirection = (ballRigidbody.transform.position - transform.position).normalized;
            ballRigidbody.AddForce(hitDirection * hitForce, ForceMode.Impulse);
        }
    }
}
