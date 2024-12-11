using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WriteText : MonoBehaviour
{
    [SerializeField] private float writeSpeed = 50f;

    public void Run(string _textToType, TMP_Text _textLabel)
    {
        StartCoroutine(TypeText(_textToType, _textLabel));
    }

    private IEnumerator TypeText(string _textToType, TMP_Text _textLabel)
    {
        float _t = 0; // The time elapsed since writing
        int _charIndex = 0; // The amount of characters written per frame

        while (_charIndex < _textToType.Length)
        {
            _t += Time.deltaTime * writeSpeed;
            _charIndex = Mathf.FloorToInt(_t);
            _charIndex = Mathf.Clamp(_charIndex, 0, _textToType.Length);

            _textLabel.text = _textToType.Substring(0, _charIndex);

            yield return null;
        }

        _textLabel.text = _textToType;
    }
}
