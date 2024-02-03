using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private HealthView[] _healthViews;
    [SerializeField] private int _max;

    private int _current;

    private void Start()
    {
        _current = _max;
        ShowInViews();
    }

    public void Add(int value)
    {
        if (value <= 0)
            return;

        if (value + _current > _max)
            _current = _max;
        else
            _current += value;

        ShowInViews();
    }

    public void Substract(int value)
    {
        if (value <= 0)
            return;

        if (value > _current)
            _current = 0;
        else
            _current -= value;

        ShowInViews();
    }

    private void ShowInViews()
    {
        foreach (HealthView view in _healthViews)
            view.Show(_current, _max);
    }
}