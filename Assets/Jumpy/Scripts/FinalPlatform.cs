using UnityEngine;

public class FinalPlatform : MonoBehaviour
{
    [SerializeField] public GameObject fox;
    
    private void OnTriggerEnter(Collider other)
    {
        bool isThisFox = other.gameObject.Equals(fox);
        bool isFoxHigher = fox.gameObject.transform.position.y > this.transform.position.y;

        if (isThisFox && isFoxHigher)
        {
            Win();
        }
    }

    void Win()
    {
        Debug.Log("HAS GANADO");
    }
}
