using UnityEngine;

public class FoxMovement : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private float jumpForce;
    private bool canJump = true;

    void Update()
    {
        checkMovement();
        checkJump();
    }

   void checkMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * velocity * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * velocity * Time.deltaTime;
        }
    }

   void checkJump()
   {
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpVector = Vector3.up * jumpForce * Time.deltaTime;
            this.GetComponent<Rigidbody>().AddForce(jumpVector);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            canJump = false;
        }
    }
}
