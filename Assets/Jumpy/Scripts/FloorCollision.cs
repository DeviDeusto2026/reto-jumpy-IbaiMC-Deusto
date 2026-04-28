using UnityEditor.Build.Content;
using UnityEngine;

public class FloorCollision : MonoBehaviour
{
    [SerializeField] private GameObject fox;
    private float oldFoxY = 0;
    private float newFoxY = Mathf.NegativeInfinity;

    private void Start()
    {
        oldFoxY = fox.transform.position.y;
    }
    void Update()
    {
        checkFox();
    }
    void checkFox()
    {
        newFoxY = fox.transform.position.y;

        if(newFoxY > oldFoxY)
        {
            this.GetComponent<BoxCollider>().isTrigger = true;
        }
        else if(newFoxY < oldFoxY)
        {
            this.GetComponent<BoxCollider>().isTrigger = false;
        }

        oldFoxY = newFoxY;
    }
}
