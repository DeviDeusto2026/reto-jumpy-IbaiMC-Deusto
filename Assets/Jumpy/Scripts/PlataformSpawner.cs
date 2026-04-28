using UnityEngine;

public class PlataformSpawner : MonoBehaviour
{
    [SerializeField] private float inicialY;
    [SerializeField] private float distanceBetweenPlatforms;
    [SerializeField] private float nPlatforms;
    private float leftMargin = -3;
    private float rightMargin = 3;
    [SerializeField] private GameObject finalPlatform;
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject fox;
    
    private void Start()
    {
        SpawnPlatforms();
    }
    void SpawnPlatforms()
    {
        Vector3 position = new Vector3(0, inicialY, 0);
        float x;
        GameObject newPlatform;

        for (int i = 0; i < nPlatforms; i++)
        {
            if (i % 2 == 0)
            {
                x = Random.Range(0, rightMargin);
            }
            else
            {
                x = Random.Range(leftMargin, 0);
            }

            position.x = x;

            newPlatform = Instantiate(platform);
            newPlatform.transform.position = position;
            newPlatform.GetComponent<FloorCollision>().fox = fox;

            position.y += distanceBetweenPlatforms;
        }

        x = Random.Range(leftMargin, rightMargin);
        position.x = x;
        newPlatform = Instantiate(finalPlatform);
        newPlatform.transform.position = position;
        newPlatform.GetComponent<FloorCollision>().fox = fox;
        newPlatform.GetComponent<FinalPlatform>().fox = fox;
    }
}