using UnityEngine;

public class Orbit : MonoBehaviour
{
    public float rotX = 0f;
    public float rotY = 75f; 
    public float rotZ = 0f;

    void Start()
    {

    }
    void Update()
    {
        transform.Rotate(rotX * Time.deltaTime, rotY * Time.deltaTime, rotZ * Time.deltaTime, Space.World);
    }
}
