using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position[1] < 6){
            direction = Vector3.up * strength;
        }
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began){
                direction = Vector3.up * strength;
            }
        }
        Debug.Log(transform.position[1]);
        if (transform.position[1] > -6){
            direction.y += gravity * Time.deltaTime;
            transform.position += direction * Time.deltaTime;
        }
    }

}
