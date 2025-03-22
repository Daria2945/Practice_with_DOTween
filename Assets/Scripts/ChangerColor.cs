using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ChangerColor : MonoBehaviour
{
    private const LoopType LoopTypeRestart = LoopType.Restart;
    private const int Repetitions = -1;
    private const Ease EaseLinear = Ease.Linear;

    [SerializeField] private float _duration;
    [SerializeField] private Color _targetColor;

    private MeshRenderer _meshRenderer;

    private void Awake()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        _meshRenderer.material.DOColor(_targetColor, _duration)
            .SetLoops(Repetitions, LoopTypeRestart)
            .SetEase(EaseLinear);
    }
}