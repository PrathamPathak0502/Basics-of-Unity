using UnityEngine;

public class GunControllerr : MonoBehaviour
{
    public GameObject bulletPrefab; 
    public Transform bulletSpawnPoint;  
    public float moveSpeed = 5f;  
    public float bulletSpeed = 10f;  

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

       
        if (Input.GetKeyDown(KeyCode.Return)) 
        {
            FireBullet();
        }
    }

    void FireBullet()
    {
        if (bulletPrefab != null && bulletSpawnPoint != null)
        {
            
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            
            // Add velocity to the bullet
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = bulletSpawnPoint.forward * bulletSpeed;
            }

           
            Destroy(bullet, 3f);
        }
    }
}
