using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update

    public List<Item> interactionItems;
    private Item targetItem;
    public GameObject questCanvas;
    private bool canvasActive = false;
    
    // Update is called once per frame
    void Update()
    {
        PickupItem();
    }

    void PickupItem()
    {
        if (CanPickup())
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                canvasActive = true;
            }
        }
        else
        {
            canvasActive = false;
        }
        questCanvas.SetActive(canvasActive);
    }

    private bool CanPickup()
    {
        foreach (var item in interactionItems)
        {
            if (item)
            {
                targetItem = item;
                float dist = Vector3.Distance(targetItem.transform.position, this.transform.position);
                if (dist < 0.8f && item.gameObject.tag == "QuestUI")
                {
                    item.ShowPickupInfo();
                    return true;
                }
            }
        }
        return false;
    }
}