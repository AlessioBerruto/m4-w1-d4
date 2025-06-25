using UnityEngine;

public class Instantiator3D : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;
    [SerializeField] private Transform _parentTransform;

    [SerializeField] private int columns = 10;  
    [SerializeField] private int rows = 10;     
    [SerializeField] private int height = 10;    

    [SerializeField] private float offsetX = 1.1f;
    [SerializeField] private float offsetY = 1.1f;
    [SerializeField] private float offsetZ = 1.1f;

    void Start()
    {
        float startX = -((columns - 1) * offsetX) / 2f;
        float startY = -((height - 1) * offsetY) / 2f;
        float startZ = -((rows - 1) * offsetZ) / 2f;

        for (int x = 0; x < columns; x++)
        {
            for (int y = 0; y < height; y++)
            {
                for (int z = 0; z < rows; z++)
                {
                    float posX = startX + x * offsetX;
                    float posY = startY + y * offsetY;
                    float posZ = startZ + z * offsetZ;

                    Vector3 position = new Vector3(posX, posY, posZ);
                    Instantiate(_cubePrefab, position, Quaternion.identity, _parentTransform);
                }
            }
        }
    }
}
