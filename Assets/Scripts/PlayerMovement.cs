using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 1000.0f;
    
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0,0,speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(0, 100 * Time.deltaTime, 0,ForceMode.Impulse);
        }
    }
}
