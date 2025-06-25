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

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform == transform)
                {
                    _renderer.material.color = ColorManager.Instance.SelectedColor;
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.transform == transform)
                {
                    _renderer.material.color = _defaultColor;
                }
            }
        }
    }
}
