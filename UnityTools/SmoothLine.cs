using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class SmoothLine : MonoBehaviour
{
    public int vertexCount = 20;
    Vector3[] vertices;
    public float lerp = 100;

    private void Start() {
        vertices = new Vector3[vertexCount];
        GetComponent<LineRenderer>().positionCount = vertexCount;
    }

    private void Update() {
        Vector2 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        for(int i = vertexCount - 1; i > 0; i--){
            vertices[i] = Vector3.Lerp(vertices[i], vertices[i - 1], lerp * Time.deltaTime);
        }
        vertices[0] = (Vector3)target;
        GetComponent<LineRenderer>().SetPositions(vertices);
    }
}
