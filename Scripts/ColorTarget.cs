using UnityEngine;

public class ColorTarget : MonoBehaviour
{
    private Renderer targetRenderer;
    private AudioSource audioSource;

    void Start()
    {
        targetRenderer = GetComponent<Renderer>();
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<ColorOrb>(out ColorOrb orb))
        {
            // 1. Change target color
            targetRenderer.material.color = orb.orbColor;

            // 2. Play sound
            if (audioSource != null)
            {
                audioSource.pitch = Random.Range(0.9f, 1.2f);
                audioSource.Play();
            }

            // 3. Tell the ball to go home after a few seconds
            orb.StartRespawnTimer();
        }
    }
}
