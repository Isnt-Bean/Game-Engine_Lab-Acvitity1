using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatableSingleton : MonoBehaviour
{
    public static EatableSingleton Instance {get; private set;}
    public GameObject food;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            Instantiate(food, new Vector3(10,0.5f,1), Quaternion.identity);
            DontDestroyOnLoad(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            //make a noise then destroy
            Destroy(gameObject);
        }
    }
}
