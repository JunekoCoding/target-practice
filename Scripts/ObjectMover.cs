using UnityEngine;

public class ObjectMover : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 2.0f; // How fast it bobs
    public float distance = 1.5f; // How far it travels
    public bool moveVertical = true; // Toggle for Up/Down vs Left/Right

    private Vector3 startPos;
    void Start()
    {
        // Step 1: Capture starting point so we stay in place
        startPos = transform.position;
    }

    void Update()
    {
        // Step 2: Sinusoidal movement
        // Mathf.Sin creates a smooth loop between -1 and 1
        float wave = Mathf.Sin(Time.time * speed) * distance;

        // Step 3: Apply movement
        if (moveVertical)
        {
            transform.position = startPos + transform.up * wave;
        }
        else
        {
            transform.position = startPos + transform.right * wave;
        }
    }
}
