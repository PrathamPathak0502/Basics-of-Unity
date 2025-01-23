using UnityEngine;

public class GunControllerr : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab for the bullet
    public Transform bulletSpawnPoint; // Spawn point for the bullet
    public float moveSpeed = 5f; // Movement speed
    public float bulletSpeed = 10f; // Speed of the bullet
    public AudioClip gunSound; // Audio clip for the gun sound
    public ParticleSystem muzzleFlash; // Muzzle flash effect
    private AudioSource audioSource; // Audio source for playing sounds

    void Start()
    {
        // Initialize the audio source
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        // Handle movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }

        // Fire bullet on pressing Enter
        if (Input.GetKeyDown(KeyCode.Return))
        {
            FireBullet();
        }
    }

    void FireBullet()
    {
        if (bulletPrefab != null && bulletSpawnPoint != null)
        {
            // Instantiate bullet
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

            // Add velocity to the bullet
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = bulletSpawnPoint.forward * bulletSpeed;
            }

            // Play gun sound
            PlayGunSound();

            // Trigger muzzle flash effect
            TriggerMuzzleFlash();

            // Destroy bullet after 3 seconds
            Destroy(bullet, 3f);
        }
    }

    void PlayGunSound()
    {
        if (gunSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(gunSound);
        }
    }

    void TriggerMuzzleFlash()
    {
        if (muzzleFlash != null)
        {
            muzzleFlash.Play();
        }
    }
}
