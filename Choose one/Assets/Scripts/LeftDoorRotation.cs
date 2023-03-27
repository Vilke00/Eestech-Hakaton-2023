using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftDoorRotation : MonoBehaviour
{
    float rotationY = 0.0f;
    public static bool canRotate = false;

    // Update is called once per frame
    void Update()
    {
        RotateDoor();
    }

    void RotateDoor()
    {
        if (canRotate)
        {
            if (rotationY < 120.0f)
            {
                rotationY += 100 * Time.deltaTime;
                // SceneManager.LoadScene("Scenes/Level1");
                //canRotate = false;
            }

            transform.rotation = Quaternion.Euler(new Vector3(0f, rotationY, 0f));
        }
    }
}
