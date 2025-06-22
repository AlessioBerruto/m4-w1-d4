using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator2D : MonoBehaviour
{
    [SerializeField] private GameObject _quadPrefab;
    [SerializeField] private GameObject _colorPickerQuadPrefab;
    [SerializeField] private GameObject _previewQuadPrefab;
    [SerializeField] private Transform _gridParentTransform;
    [SerializeField] private int rows = 10;
    [SerializeField] private int columns = 10;
    [SerializeField] private float offsetX = 1.1f;
    [SerializeField] private float offsetZ = 1.1f;

    private readonly Color[] _pickerColors = new Color[]
{
    Color.white,
    Color.black,
    Color.red,
    Color.green,
    Color.blue
};


    void Start()
    {
        float startX = -((columns - 1) * offsetX) / 2f;
        float startZ = -((rows - 1) * offsetZ) / 2f;
        float pickerZ = startZ - offsetZ * 1.5f;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                float posX = startX + col * offsetX;
                float posZ = startZ + row * offsetZ;
                Vector3 position = new Vector3(posX, 0, posZ);

                GameObject quad = Instantiate(_quadPrefab, position, _quadPrefab.transform.rotation, _gridParentTransform);
            }
        }

        for (int i = 0; i < _pickerColors.Length; i++)
        {
            float posX = startX + i * offsetX;
            Vector3 position = new Vector3(posX, 0f, pickerZ);

            GameObject colorQuad = Instantiate(_colorPickerQuadPrefab, position, _colorPickerQuadPrefab.transform.rotation, _gridParentTransform);

            Renderer rend = colorQuad.GetComponent<Renderer>();
            rend.material = new Material(rend.material); 
            rend.material.color = _pickerColors[i];
        }

        float previewX = startX + (columns - 1) * offsetX;
        Vector3 previewPos = new Vector3(previewX, 0f, pickerZ);

        GameObject previewQuad = Instantiate(_previewQuadPrefab, previewPos, _previewQuadPrefab.transform.rotation, _gridParentTransform);
        previewQuad.name = "PreviewQuad";
    }

}
