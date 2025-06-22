using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour
{
    private Renderer _renderer;
    private Color _defaultColor;
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _renderer.material = new Material(_renderer.material);
        _defaultColor = _renderer.material.color;
    }

    private void OnMouseDown()
    {
        _renderer.material.color = ColorManager.Instance.SelectedColor;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (IsMouseOverThisObject())
            {
                _renderer.material.color = _defaultColor;
            }
        }
    }

    private bool IsMouseOverThisObject()
    {
        return _isMouseOver;
    }

    private bool _isMouseOver = false;

    private void OnMouseEnter()
    {
        _isMouseOver = true;
    }
    private void OnMouseExit()
    {
        _isMouseOver = false;
    }
}
