using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneButton : MonoBehaviour
{
    //public string sceneToLoadOnButton1;
    //public string sceneToLoadOnButton2;
    //public DoorRotation1 door1;
    //public DoorRotation2 door2;

    public GameObject box;
    public Canvas canvas;
    public AudioSource audio;
    void Start()
    {
        Button btn1 = transform.Find("Background/Choice one")?.GetComponent<Button>();
        if (btn1 != null) {
            btn1.onClick.AddListener(LoadScene1);
            
        } else {
            Debug.LogError("Button1 not found or not a Button component.");
        }

        Button btn2 = transform.Find("Background/Choice two")?.GetComponent<Button>();
        if (btn2 != null) {
            btn2.onClick.AddListener(LoadScene2);
            
        } else {
            Debug.LogError("Button2 not found or not a Button component.");
        }
    }

    void LoadScene1()
    {
        //SceneManager.LoadScene(sceneToLoadOnButton1);
       // canvas.SetActive(false);
        canvas.enabled = false;
        LeftDoorRotation.canRotate = true;
    }

    void LoadScene2()
    {
        //SceneManager.LoadScene(sceneToLoadOnButton2);
       // canvas.SetActive(false);
       canvas.enabled = false;
        RightDoorRotation.canRotate = true;
        audio.Play();
        
        Destroy(box);
    }
}
