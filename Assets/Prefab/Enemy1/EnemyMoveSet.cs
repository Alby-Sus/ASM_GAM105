using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2f;
    private Transform target;

    private void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        // Quái di chuyển về phía người chơi
        if (target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

    }
}
