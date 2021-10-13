using UnityEngine;
using UnityEngine.Events;
public class Walls : MonoBehaviour
{
    public UnityEvent _GoalEvent;
    private object other;

   
    [SerializeField]
    private BoxCollider2D collider;

    public BoxCollider2D Collider { get => collider; private set => collider = value; }


    private void Start()
    {
        if (!Collider)
        {
            Collider = GetComponent<BoxCollider2D>();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            _GoalEvent.Invoke();
            return;
        }


    }
}
