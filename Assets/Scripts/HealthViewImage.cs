using UnityEngine.UI;
using UnityEngine;

public class HealthViewImage : HealthView
{
    [SerializeField] private Image _image;

    public override void Show(int current, int max)
    {
        _image.fillAmount = (float)current / max;
    }
}