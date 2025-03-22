using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private const LoopType LoopTypeRestart = LoopType.Restart;
    private const int Repetitions = -1;
    private const Ease EaseLinear = Ease.Linear;

    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _tardetRotation;

    private void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.DORotate(_tardetRotation, _duration)
            .SetLoops(Repetitions, LoopTypeRestart)
            .SetEase(EaseLinear);
    }
}