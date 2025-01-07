using UnityEngine;

public class GunMovement : MonoBehaviour
{
    [Header("Gun Settings")]
    public Transform gunPivot; // The pivot point of the gun
    public float rotationSpeed = 5f; // Speed of the gun's rotation
    public Vector3 minRotation = new Vector3(-60f, -60f, 0f); // Minimum rotation limits (X, Y, Z)
    public Vector3 maxRotation = new Vector3(60f, 60f, 0f); // Maximum rotation limits (X, Y, Z)

    void Update()
    {
        HandleGunMovement();
    }

    private void HandleGunMovement()
    {
       
        Vector3 mousePosition = Input.mousePosition;

       
        Ray ray = Camera.main.ScreenPointToRay(mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
           
            Vector3 targetDirection = hit.point - gunPivot.position;

            
            Quaternion targetRotation = Quaternion.LookRotation(targetDirection);

           
            gunPivot.rotation = Quaternion.Slerp(gunPivot.rotation, targetRotation, Time.deltaTime * rotationSpeed);

        
            Vector3 clampedEuler = gunPivot.rotation.eulerAngles;
            clampedEuler.x = ClampAngle(clampedEuler.x, minRotation.x, maxRotation.x);
            clampedEuler.y = ClampAngle(clampedEuler.y, minRotation.y, maxRotation.y);
            clampedEuler.z = ClampAngle(clampedEuler.z, minRotation.z, maxRotation.z);

           
            gunPivot.rotation = Quaternion.Euler(clampedEuler);
        }
    }

    private float ClampAngle(float angle, float min, float max)
    {
        if (angle > 180f) angle -= 360f;
        angle = Mathf.Clamp(angle, min, max);
        return angle;
    }
}
