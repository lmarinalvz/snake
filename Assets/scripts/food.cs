using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    [SerializeField] private BoxCollider2D grid;

    private void Start()
    {
        moveToRandomPosition();
    }

    public void moveToRandomPosition()
    {
        int randomX = (int)Random.Range(grid.bounds.min.x, grid.bounds.max.x);
        int randomY = (int)Random.Range(grid.bounds.min.y, grid.bounds.max.y);
        transform.position = new Vector3(randomX, randomY, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("snake"))
        {
            moveToRandomPosition();
        }
    }
}