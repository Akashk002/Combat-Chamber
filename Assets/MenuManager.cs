using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> panelList;


    public void OpenPanel(PanelType panelType)
    {
        foreach (GameObject panel in panelList)
        {
            panel.SetActive(false);
        }

        panelList[(int)panelType].SetActive(true);
    }
}

public enum PanelType
{
    Loading,
    Menu,
    CreateRoom,
    Room,
    FindRoom
}