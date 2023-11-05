
using UnityEngine;

public class rotateonycar : MonoBehaviour
{
    public float rotationSpeed = 90.0f; // Set your desired rotation speed here (degrees per second).

    // Update is called once per frame
    void Update()
    {
        // Rotate the GameObject on the Y-axis
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
