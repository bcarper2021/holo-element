using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// class created to handle when a button is clicked 
public class ButtonObjectSpawn : MonoBehaviour, IInputClickHandler
{
    public GameObject spawnObjectManagerObj;
    
    public void OnInputClicked(InputClickedEventData eventData)
    {
        spawnObjectManagerObj.GetComponent<SpawnObjectManager>().SpawnObjectSwitched(gameObject.name);
    }
}
