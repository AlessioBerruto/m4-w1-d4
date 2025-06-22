using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviewQuad : MonoBehaviour
{
    [SerializeField] private Color selectedColor;
    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _renderer.material = new Material(_renderer.material);
    }

    void Update()
    {
        if (selectedColor != ColorManager.Instance.SelectedColor)
        {
            selectedColor = ColorManager.Instance.SelectedColor;
            _renderer.material.color = selectedColor;
        }
    }
}
