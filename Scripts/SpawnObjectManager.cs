using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class created to manage the creation and switching of product objects' visibility
public class SpawnObjectManager : MonoBehaviour {

    /* To add a new object, add the prefab to the array attached to ObjectSpawnPoint
     * Then, enable the next button available out of the 8 total buttons
     * Be sure to scale and center the added product as well as attach the RotateObject script */

    public GameObject[] Products;
    private Dictionary<string, GameObject> ButtonToProduct = new Dictionary<string, GameObject>();

    // spawns all objects at the spawnpoint and hides all visibility
    // also initializes a dictionary
    void Start()
    {
        ButtonToProduct = new Dictionary<string, GameObject>();
        int row = 0;
        int col = 0;
        foreach (GameObject product in Products)
        {
            string buttonNameBuilder = "ProductTile" + ((row / 4) + 1) + ((col % 4) + 1);
            ButtonToProduct.Add(buttonNameBuilder, Instantiate(product,
                                         new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z),
                                         Quaternion.identity) as GameObject);
            ButtonToProduct[buttonNameBuilder].transform.parent = gameObject.transform;
            ButtonToProduct[buttonNameBuilder].SetActive(false);
            row++;
            col++;
        }


        // use the following code segment to print out what is included in the dictionary
        /*
        foreach (KeyValuePair<string, GameObject> entry in ButtonToProduct)
        {
            Debug.Log(entry.Key);
            Debug.Log(entry.Value);
        }
        */
    }


    // called every time a new button is pressed to switch currently visible product
    // called from buttonObjectSpawn
    public void SpawnObjectSwitched(string buttonPressedName)
    {
        // set all products' visibility to false
        foreach (KeyValuePair<string, GameObject> entry in ButtonToProduct)
        {
            entry.Value.SetActive(false);
        }

        // set the selected product visibility to true
        ButtonToProduct[buttonPressedName].SetActive(true);
    }
}
