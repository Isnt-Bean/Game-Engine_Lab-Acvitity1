using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Food : MonoBehaviour
{
    public GameObject food;
    

    void Update()
    {
        GameObject[] foods = GameObject.FindGameObjectsWithTag("Food");
        if (foods.Length == 0)
        {
            int randx = UnityEngine.Random.Range(-22, 25);
            int randz = UnityEngine.Random.Range(-16, 4);
            Instantiate(food, new Vector3(randx,0.5f,randz), Quaternion.identity);
        }
    }

}
