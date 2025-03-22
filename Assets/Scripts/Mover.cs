using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private const LoopType LoopTypeYoyo = LoopType.Yoyo;
    private const int Repetitions = -1;
    private const Ease EaseLinear = Ease.Linear;

    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _tardetPosition;

    private void Start()
    {
        Move();
    }

    private void Move()
    {
        transform.DOMove(_tardetPosition, _speed)
            .SetSpeedBased()
            .SetLoops(Repetitions, LoopTypeYoyo)
            .SetEase(EaseLinear);
    }
}