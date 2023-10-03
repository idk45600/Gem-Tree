using UnityEngine;

public class FirstPersonAudio : MonoBehaviour
{
    public FirstPersonInput fPInput;
    
    [Header("Step")]
    public AudioSource stepAudio;
    [Tooltip("Minimum velocity for moving audio to play")]
    /// <summary> "Minimum velocity for moving audio to play" </summary>
    public float velocityThreshold = .01f;

    void Start()
    {
        // Setup stuff.
        fPInput = GetComponentInParent<FirstPersonInput>();
    }

    void Update()
    {
        // Play moving audio if the character is moving and on the ground.
        float velocity = fPInput.moveVector.magnitude;
        if (velocity >= velocityThreshold)
        {
            if (!stepAudio.isPlaying)
            {
                stepAudio.Play();
            }

            if (fPInput.isSprinting)
            {
                stepAudio.pitch = 1.1f;
            }
            else 
            {
                stepAudio.pitch = 0.9f;
            }

        }
        else
        {
            stepAudio.Stop();
        }
    }
}
