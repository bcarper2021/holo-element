using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class created to show and hide the object that allows the spawn point to be moved
public class SpawnPointManipulate : MonoBehaviour, IInputClickHandler
{
    // object holding script that manipulates the spawn point
    public GameObject spawnObjectManagerObj;

    // handles when the toggle button is pressed
    public void OnInputClicked(InputClickedEventData eventData)
    {
        // locks or unlocks the manipulation of products
        spawnObjectManagerObj.GetComponent<HandDraggable>().enabled = !spawnObjectManagerObj.GetComponent<HandDraggable>().enabled;
    }
}