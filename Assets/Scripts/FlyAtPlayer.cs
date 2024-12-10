using UnityEngine;
using NumericsVector3 = System.Numerics.Vector3;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] Transform player;
    UnityEngine.Vector3 playerPosition;

    private void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.position;
    }

    void Update()
    {
        if (transform.position != playerPosition)
        {
            MoveToPlayer();
            DestroyWhenReached();
        }
    }

    void DestroyWhenReached()
    {
        if (UnityEngine.Vector3.Distance(transform.position, playerPosition) < 0.01f)
        {
            Destroy(gameObject);
        }
    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }
}

