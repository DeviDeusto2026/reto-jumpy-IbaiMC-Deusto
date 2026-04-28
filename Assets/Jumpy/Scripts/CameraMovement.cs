using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private GameObject fox;
    private float downMargin;
    private void Start()
    {
        downMargin = this.transform.position.y - 9;
    }

    void Update()
    {
        CheckY();
    }

    private void FixedUpdate()
    {
        MoveCamera();
    }

    void CheckY()
    {
        if(fox.transform.position.y < downMargin)
        {
            Lose();
        }
    }
    void MoveCamera()
    {
        this.transform.position += Vector3.up * velocity * Time.deltaTime;
        downMargin += velocity * Time.deltaTime;
    }
    void Lose()
    {
        Debug.Log("HAS PERDIDO");
    }
}
