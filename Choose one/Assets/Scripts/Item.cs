using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Canvas pickupInfo;
    // Start is called before the first frame update
    void Start()
    {
        InitPickupInfoOverObject();
    }

    // Update is called once per frame
    void Update()
    {
        pickupInfo.transform.position = this.transform.position + new Vector3(0f, 5.0f, 0.0f);
    }

    void InitPickupInfoOverObject()
    {
     //   pickupInfo.enabled = false;
        //   Instantiate(pickupInfo);
        //   pickupInfo.transform.position = this.transform.position + new Vector3(0f, 5.0f, 0.0f);

    }

    public void ShowPickupInfo()
    {
        pickupInfo.enabled = true;
    }
}
