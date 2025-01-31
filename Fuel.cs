using UnityEngine;

public class CarMovementAndRefueling : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float fuel = 100f; 
    public float fuelConsumptionRate = 1f; 
    public float refuelAmount = 50f; 
    public float maxFuel = 100f;
    public AudioClip refuelSound; 
    private AudioSource audioSource;

    private Rigidbody carRigidbody;

    void Start()
    {
      
        carRigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
      
        HandleCarMovement();

      
        if (fuel > 0)
        {
            fuel -= fuelConsumptionRate * Time.deltaTime;
        }
        else
        {
            fuel = 0;
        }

   
        if (fuel > maxFuel)
        {
            fuel = maxFuel;
        }

        // Debug output (optional)
        Debug.Log("Fuel: " + fuel);
    }

 
    void Refuel()
    {
       
        if (fuel < maxFuel)
        {
            fuel += refuelAmount;
            if (fuel > maxFuel)
            {
                fuel = maxFuel;
            }

       
            if (refuelSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(refuelSound);
            }

            Debug.Log("Car refueled. Fuel: " + fuel);
        }
    }
}
