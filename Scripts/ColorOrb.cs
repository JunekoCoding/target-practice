using UnityEngine;

public class ColorOrb : MonoBehaviour
{
    public Color orbColor = Color.white;
    public float respawnDelay = 5f; // How long to wait before coming back

    private Vector3 startPos;
    private Quaternion startRot;
    private Rigidbody rb;

    void Start()
    {
        // Set the color
        if (TryGetComponent<Renderer>(out Renderer renderer))
        {
            renderer.material.color = orbColor;
        }

        // Save the "Home" position
        startPos = transform.position;
        startRot = transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Safety Net: If it falls off the table, reset it immediately
        if (transform.position.y < -5f)
        {
            ResetOrb();
        }
    }

    // This is called by the Target when the ball hits it
    public void StartRespawnTimer()
    {
        // Wait X seconds, then run the ResetOrb function
        Invoke("ResetOrb", respawnDelay);
    }

    public void ResetOrb()
    {
        // Cancel any pending timers so we don't double-reset
        CancelInvoke("ResetOrb");

        // Teleport home
        transform.position = startPos;
        transform.rotation = startRot;

        // Stop it from moving/falling
        if (rb != null)
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
