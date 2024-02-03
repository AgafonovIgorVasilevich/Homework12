using UnityEngine;
using TMPro;

public class HealthViewText : HealthView
{
    [SerializeField] private TMP_Text _text;

    public override void Show(int current, int max)
    {
        _text.text = $"{current}/{max}";
    }
}