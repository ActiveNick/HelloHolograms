using UnityEngine;
using System.Collections;

public class ProjectileLauncher : MonoBehaviour
{

    /// <summary>
    /// Keep Track of the allowed shot interval to throttle users' shots
    /// </summary>
    public int shotsPerSec = 4;

    /// <summary>
    /// Keep Track of the last shot time to throttle users' shots
    /// </summary>
    float LastShotTime = 0;

    public Rigidbody m_Sphere;                  // Prefab of the sphere
    public Transform m_Origin;                  // Where the shells are spawned
    public AudioSource m_ShootingAudio;         // Reference to the audio source used to play the shooting audio
    public AudioClip m_FireClip;                // Audio that plays when each shot is fired
    public float m_CurrentLaunchForce = 10.0f;  // The force that will be given to the sphere when the tap gesture is triggered

    private void OnEnable()
    {

    }

    // Use this for initialization
    void Start()
    {

    }

    /// <summary>
    /// OnFire is sent by gesture manager.
    /// </summary>
    void OnFire()
    {
        if ((Time.realtimeSinceStartup - LastShotTime) > (1 / shotsPerSec))
        {
            LastShotTime = Time.realtimeSinceStartup;
            Fire();
        }
    }

    private void Fire()
    {
        // Create an instance of the sphere and store a reference to it's rigidbody.
        Rigidbody ballInstance =
            Instantiate(m_Sphere, m_Origin.position, m_Origin.rotation) as Rigidbody;

        // Set the sphere's velocity to the launch force in the fire position's forward direction.
        ballInstance.velocity = m_CurrentLaunchForce * m_Origin.forward;

        // Change the clip to the firing clip and play it.
        m_ShootingAudio.clip = m_FireClip;
        m_ShootingAudio.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
