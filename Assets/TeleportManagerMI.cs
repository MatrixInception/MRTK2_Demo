using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Teleport;
using Microsoft.MixedReality.Toolkit.Input;

public class TeleportManagerMI : MonoBehaviour
{
    TeleportPointer tPointer;
    TeleportHotSpot tHotspot;
    public TeleportCursor tCursor; 

    // Start is called before the first frame update
    void Start()
    {
        EnableTeleportSystem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DisableTeleportSystem()
    {
        CoreServices.TeleportSystem.Disable();
    }

    void EnableTeleportSystem()
    {
        CoreServices.TeleportSystem.Enable();
    }
}
