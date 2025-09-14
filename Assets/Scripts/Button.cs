using UnityEngine;
using System.Collections;
using TMPro;

public class Button : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private int _count = 0;
    [SerializeField] private int _maxCount = 10;

    private Coroutine _ñoroutine;

    private void Start()
    {
        UpdateText();
    }

    public void OnButtonClick()
    {
        if (_ñoroutine == null)
            _ñoroutine = StartCoroutine(Numeration());
        else
            StopCounting();
    }

    private void StopCounting()
    {
        if (_ñoroutine != null)
        {
            StopCoroutine(_ñoroutine);
            _ñoroutine = null;
        }

    }

    private IEnumerator Numeration()
    {
        bool isWork = true;

        while (isWork)
        {
            yield return new WaitForSeconds(0.5f);
            _count++;

            if (_count >= _maxCount)
            {
                _text.text = _count.ToString("Ñ÷¸ò çàêîí÷åí");
                isWork = false;
                yield break;
            }

            UpdateText();
        }
    }

    private void UpdateText()
    {
        _text.text = _count.ToString();
    }
}
