using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 1f;

    void Update()
    {
        // Di chuyển nhân vật sang phải theo thời gian
        transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }
}