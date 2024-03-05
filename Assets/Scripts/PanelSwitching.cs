using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSwitching : MonoBehaviour
{
    public GameObject habitatPanel, bgStoryPanel;
    
    public void OpenHabitat()
    {
        habitatPanel.SetActive(true);
        bgStoryPanel.SetActive(false);
    }
    public void OpenBGStory()
    {
        habitatPanel.SetActive(false);
        bgStoryPanel.SetActive(true);
    }
}
