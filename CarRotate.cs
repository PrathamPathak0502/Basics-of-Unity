using UnityEngine;

public class CarRotate : MonoBehaviour
{
    public float turnSpeed = 50f; 
    public float turnDuration = 3f; 
    private float turnAmount = 0f;
    private bool isTurning = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            StartCoroutine(Perform360Turn());
        }
    }

    private System.Collections.IEnumerator Perform360Turn()
    {
        float startTime = Time.time;

        while (Time.time < startTime + turnDuration)
        {
            float progress = (Time.time - startTime) 
            turnAmount = Mathf.Lerp(0f, 360f, progress); 

           
            transform.rotation = Quaternion.Euler(0f, turnAmount, 0f);

            yield return null; 
        }

      
        transform.rotation = Quaternion.Euler(0f, 360f, 0f);
        isTurning = false;
    }
}
