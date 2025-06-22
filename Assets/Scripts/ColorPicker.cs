using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    private Color _colorToPick;

    private void Start()
    {
        _colorToPick = GetComponent<Renderer>().material.color;
    }

    private void OnMouseDown()
    {
        ColorManager.Instance.SetColor(_colorToPick);      
    }
}
