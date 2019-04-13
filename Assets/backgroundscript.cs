using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundscript : MonoBehaviour
{
    public Vector2 startPosition;
    public float tileSizeZ;
    public float scrollSpeed;
    private void Update()
    {
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        transform.position = startPosition + Vector2.down * newPosition;
    }


}
