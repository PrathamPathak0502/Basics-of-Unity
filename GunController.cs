using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    public GameObject _bullet;
    public Transform _bulletspawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.RightArrow))
            transform.Translate(Vector3.right *1.0f * Time.deltaTime);
        if (Input.GetKeyUp(KeyCode.LeftArrow))
            transform.Translate(Vector3.left * 1.0f * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.Space))
            Instantiate(_bullet,_bulletspawnpoint.position , _bulletspawnpoint.rotation);
    }
}
