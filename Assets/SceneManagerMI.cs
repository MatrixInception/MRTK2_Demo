using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneManagerMI : MonoBehaviour
{
    public int sceneIndex; 
    int sceneIndexOffset=1;
    TextMeshPro textMesh; 


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        textMesh = transform.Find("SceneNameText").GetComponent<TextMeshPro>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = SceneManager.GetActiveScene().name;
    }

    public void GoToNextScene()
    {
        if (SceneManager.sceneCountInBuildSettings > sceneIndexOffset + 1)
        {
            sceneIndex = (sceneIndex + 1) % (SceneManager.sceneCountInBuildSettings- sceneIndexOffset);

        }
        else
        {
            sceneIndex = 0; 
        }

        SceneManager.LoadSceneAsync(sceneIndex + sceneIndexOffset);
    }

    public void GoToPreviousScene()
    {
        if (SceneManager.sceneCountInBuildSettings > sceneIndexOffset+1)
        {
            if (sceneIndex == 0)
            {
                sceneIndex = SceneManager.sceneCountInBuildSettings - sceneIndexOffset-1;

            }
            else
            {
                sceneIndex = (sceneIndex - 1) % (SceneManager.sceneCountInBuildSettings - sceneIndexOffset);
            }

        }
        else
        {
            sceneIndex = 0;
        }

        SceneManager.LoadSceneAsync(sceneIndex + sceneIndexOffset);

    }
}
