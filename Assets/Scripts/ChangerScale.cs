using DG.Tweening;
using UnityEngine;

public class ChangerScale : MonoBehaviour
{
    private const LoopType LoopTypeYoyo = LoopType.Yoyo;
    private const int Repetitions = -1;
    private const Ease EaseLinear = Ease.Linear;

    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _tardetScale;

    private void Start()
    {
        ChangeScale();
    }

    private void ChangeScale()
    {
        transform.DOScale(_tardetScale, _duration)
            .SetLoops(Repetitions, LoopTypeYoyo)
            .SetEase(EaseLinear);
    }
}