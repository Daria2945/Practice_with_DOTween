using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ChangerText : MonoBehaviour
{
    private const int Repetitions = -1;

    [SerializeField] private float _duration;
    [SerializeField] private Text _text;
    [SerializeField] private string _replacementText;
    [SerializeField] private string _textToAdd;

    private void Start()
    {
        Sequence mySequence = DOTween.Sequence();

        mySequence.Append(Replace());
        mySequence.Append(Add());
        mySequence.Append(ReplaceBySymbol());

        mySequence.SetLoops(Repetitions);
    }

    private Tween Replace() =>
        _text.DOText(_replacementText, _duration);

    private Tween Add() =>
        _text.DOText(_textToAdd, _duration).SetRelative();

    private Tween ReplaceBySymbol() =>
        _text.DOText(_replacementText, _duration, true, ScrambleMode.Lowercase);
}