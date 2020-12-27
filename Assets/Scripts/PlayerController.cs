using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKey("space")) {
            if (Input.GetKey("left")) {
                Shoot();
                gameObject.transform.Translate(-5f * Time.deltaTime,0,0);
            }
            if (Input.GetKey("right")) {
                gameObject.transform.Translate(5f * Time.deltaTime,0,0);
            }
            if (Input.GetKey("up")) {
                gameObject.transform.Translate(0,5f * Time.deltaTime,0);
            }
            if (Input.GetKey("down")) {
                gameObject.transform.Translate(0,-5f * Time.deltaTime,0);
            }
        }
    }

    void Shoot() {
        
    }
}
