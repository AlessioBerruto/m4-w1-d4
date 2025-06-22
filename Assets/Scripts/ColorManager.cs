using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static ColorManager Instance { get; private set; }

    public Color SelectedColor { get; private set; } = Color.white;

    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(gameObject);
        else
            Instance = this;
    }

    public void SetColor(Color newColor)
    {
        SelectedColor = newColor;
    }
}
