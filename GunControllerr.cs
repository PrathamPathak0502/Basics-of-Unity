using UnityEngine;

public class GunControllerr : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float moveSpeed = 5f;
    public float bulletSpeed = 10f;
    public AudioClip gunSound;
    public ParticleSystem muzzleFlash;
    private AudioSource audioSource;
    private bool isAutomatic = true;
    private bool isReloading = false;
    private int maxAmmo = 10;
    private int currentAmmo;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
        currentAmmo = maxAmmo;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Return) && !isReloading && currentAmmo > 0)
        {
            FireBullet();
        }

        if (Input.GetKeyDown(KeyCode.R) && !isReloading)
        {
            StartCoroutine(ReloadGun());
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            SwitchFireMode();
        }
    }

    void FireBullet()
    {
        if (bulletPrefab != null && bulletSpawnPoint != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = bulletSpawnPoint.forward * bulletSpeed;
            }
            PlayGunSound();
            TriggerMuzzleFlash();
            Destroy(bullet, 3f);
            currentAmmo--;
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

    void SwitchFireMode()
    {
        isAutomatic = !isAutomatic;
    }

    System.Collections.IEnumerator ReloadGun()
    {
        isReloading = true;
        yield return new WaitForSeconds(2f); // Simulate reload time
        currentAmmo = maxAmmo;
        isReloading = false;
    }
}
