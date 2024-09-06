using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public float CubeRotSpeed;
    // Start is called before the first frame update
    void Start()
    {
        CubeRotSpeed = 50.0f;
    }

    // Update is called once per frame
    void Update()
    {
        CubeRotate();
    }
    void CubeRotate()
    {
        transform.Rotate(Vector3.up, CubeRotSpeed * Time.deltaTime);
    }
}
