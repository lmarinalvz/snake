using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class snake : MonoBehaviour
{
    public Vector3 currentPosition = Vector3.right;
    [SerializeField] private Transform segmentPrefab;
    private List<Transform> segments;

    private void Start()
    {
        segments = new List<Transform>();
        segments.Add(transform);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && currentPosition != Vector3.down)
        {
            currentPosition = Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.S) && currentPosition != Vector3.up)
        {
            currentPosition = Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.A) && currentPosition != Vector3.right)
        {
            currentPosition = Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D) && currentPosition != Vector3.left)
        {
            currentPosition = Vector3.right;
        }
    }

    private void FixedUpdate()
    {
        for (int i = segments.Count - 1; i > 0; i--)
        {
            segments[i].position = segments[i - 1].position;
        }
        transform.position += currentPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("food"))
        {
            Transform segment = Instantiate(segmentPrefab);
            segment.position = segments[segments.Count - 1].position;
            segments.Add(segment);
        }
    }
}