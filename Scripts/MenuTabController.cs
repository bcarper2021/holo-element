using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTabController : MonoBehaviour, IInputClickHandler
{
    public GameObject ProductMenuTab;
    public GameObject SimulateMenuTab;
    public GameObject SettingsMenuTab;

    private readonly float TabDistanceSelected = -0.007f;
    private readonly float TabDistanceNotSelected = 0.005f;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        MenuBodyController menuBodyControllerScript = GameObject.Find("MenuManager").GetComponent<MenuBodyController>();
        if (gameObject.name == "ProductMenuTab")
        {
            menuBodyControllerScript.ProductMenuSelected = true;
            ProductMenuTab.transform.localPosition = new Vector3(ProductMenuTab.transform.localPosition.x, ProductMenuTab.transform.localPosition.y, TabDistanceSelected);
            menuBodyControllerScript.SimulateMenuSelected = false;
            SimulateMenuTab.transform.localPosition = new Vector3(SimulateMenuTab.transform.localPosition.x, SimulateMenuTab.transform.localPosition.y, TabDistanceNotSelected);
            menuBodyControllerScript.SettingsMenuSelected = false;
            SettingsMenuTab.transform.localPosition = new Vector3(SettingsMenuTab.transform.localPosition.x, SettingsMenuTab.transform.localPosition.y, TabDistanceNotSelected);
            menuBodyControllerScript.OnMenuChanged();
        }
        else if (gameObject.name == "SimulateMenuTab")
        {
            menuBodyControllerScript.ProductMenuSelected = false;
            ProductMenuTab.transform.localPosition = new Vector3(ProductMenuTab.transform.localPosition.x, ProductMenuTab.transform.localPosition.y, TabDistanceNotSelected);
            menuBodyControllerScript.SimulateMenuSelected = true;
            SimulateMenuTab.transform.localPosition = new Vector3(SimulateMenuTab.transform.localPosition.x, SimulateMenuTab.transform.localPosition.y, TabDistanceSelected);
            menuBodyControllerScript.SettingsMenuSelected = false;
            SettingsMenuTab.transform.localPosition = new Vector3(SettingsMenuTab.transform.localPosition.x, SettingsMenuTab.transform.localPosition.y, TabDistanceNotSelected);
            menuBodyControllerScript.OnMenuChanged();
        }
        else if (gameObject.name == "SettingsMenuTab")
        {
            menuBodyControllerScript.ProductMenuSelected = false;
            ProductMenuTab.transform.localPosition = new Vector3(ProductMenuTab.transform.localPosition.x, ProductMenuTab.transform.localPosition.y, TabDistanceNotSelected);
            menuBodyControllerScript.SimulateMenuSelected = false;
            SimulateMenuTab.transform.localPosition = new Vector3(SimulateMenuTab.transform.localPosition.x, SimulateMenuTab.transform.localPosition.y, TabDistanceNotSelected);
            menuBodyControllerScript.SettingsMenuSelected = true;
            SettingsMenuTab.transform.localPosition = new Vector3(SettingsMenuTab.transform.localPosition.x, SettingsMenuTab.transform.localPosition.y, TabDistanceSelected);
            menuBodyControllerScript.OnMenuChanged();
        }
    }
}
