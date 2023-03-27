using UnityEngine;
using DG.Tweening;

public class BasicMover : MonoBehaviour
{
    public Transform EndPos;
    public GameObject Camera;
    public float MoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        Camera.transform.DOMove(EndPos.position, MoveSpeed).SetEase(Ease.Linear);
    }

}
