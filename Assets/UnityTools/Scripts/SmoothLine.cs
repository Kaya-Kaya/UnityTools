using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class SmoothLine : MonoBehaviour
{
    public Transform target;
    public int vertexCount = 20;
    Vector3[] vertices;
    public float speed = 10;

    private void Start() {
        vertices = new Vector3[vertexCount];
        GetComponent<LineRenderer>().positionCount = vertexCount;
    }

    private void Update() {
        Vector2 targetPos = target ? target.position : Camera.main.ScreenToWorldPoint(Input.mousePosition);

        for(int i = vertexCount - 1; i > 0; i--){
            vertices[i] = Vector3.Lerp(vertices[i], vertices[i - 1], speed * 10 * Time.deltaTime);
        }
        vertices[0] = (Vector3)targetPos;
        GetComponent<LineRenderer>().SetPositions(vertices);
    }
}
