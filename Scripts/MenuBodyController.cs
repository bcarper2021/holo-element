using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBodyController : MonoBehaviour
{
    public bool ProductMenuSelected { get; set; }
    public bool SimulateMenuSelected { get; set; }
    public bool SettingsMenuSelected { get; set; }

    public GameObject ProductMenuBody;
    public GameObject SimulateMenuBody;
    public GameObject SettingsMenuBody;

    public GameObject ProductMenuTab;
    public GameObject SimulateMenuTab;
    public GameObject SettingsMenuTab;

    private readonly float TabDistanceSelected = -0.007f;
    private readonly float TabDistanceNotSelected = 0.005f;

    void Start()
    {
        ProductMenuSelected = true;
        SimulateMenuSelected = false;
        SettingsMenuSelected = false;

        ProductMenuTab.transform.localPosition = new Vector3(ProductMenuTab.transform.localPosition.x, ProductMenuTab.transform.localPosition.y, TabDistanceSelected);
        SimulateMenuTab.transform.localPosition = new Vector3(SimulateMenuTab.transform.localPosition.x, SimulateMenuTab.transform.localPosition.y, TabDistanceNotSelected);
        SettingsMenuTab.transform.localPosition = new Vector3(SettingsMenuTab.transform.localPosition.x, SettingsMenuTab.transform.localPosition.y, TabDistanceNotSelected);

        OnMenuChanged();
    }

    public void OnMenuChanged()
    {
        if (ProductMenuSelected)
        {
            ProductMenuBody.SetActive(true);
            SimulateMenuBody.SetActive(false);
            SettingsMenuBody.SetActive(false);
        }
        else if (SimulateMenuSelected)
        {
            ProductMenuBody.SetActive(false);
            SimulateMenuBody.SetActive(true);
            SettingsMenuBody.SetActive(false);
        }
        else if (SettingsMenuSelected)
        {
            ProductMenuBody.SetActive(false);
            SimulateMenuBody.SetActive(false);
            SettingsMenuBody.SetActive(true);
        }
    }
}
