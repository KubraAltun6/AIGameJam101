using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryPass : MonoBehaviour
{
    [SerializeField] private GameObject[] storyPanels;

    int storyCount;

    int currentCount = 0;

    private void Start()
    {
        storyCount = storyPanels.Length;

        foreach(GameObject go in storyPanels)
        {
            go.SetActive(false);
        }
        storyPanels[0].SetActive(true);
    }

    public void buttonPress()
    {
        if (currentCount < storyCount - 1)
        {
            storyPanels[currentCount].SetActive(false);
            currentCount++;
            storyPanels[currentCount].SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Gecmis");
        }
    }


}
