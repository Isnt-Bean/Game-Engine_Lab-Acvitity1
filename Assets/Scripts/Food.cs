using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject food;
    
    public void instantiate()
    {
        float x = Random.Range(-23f, 25f);
        float z = Random.Range(-16.5f, 4.5f);
        
        //instantiate a new food on a random point of the platform that isn't in the wall
        Instantiate(food, new Vector3(x,0.5f,z), transform.rotation);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            //make a noise then destroy
            instantiate();
            Destroy(gameObject);
        }
    }
}
