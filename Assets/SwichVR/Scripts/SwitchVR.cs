////////////////////////////////////////////////////////////////////////////////
//
//  MIZUTANI KIRIN
//  Copyright 2020 MIZUTANI KIRIN All Rights Reserved.
//
////////////////////////////////////////////////////////////////////////////////
using System.Collections;
using UnityEngine;
using UnityEngine.XR;

public class SwitchVR : MonoBehaviour {

    public string deviceName = "Cardboard";
    public bool initXREnable;

    private string deviceNone = "None";

    private void Awake() {
        XRSettings.enabled = initXREnable;
    }

    //----------------------------------
    //  XR切り替え
    //----------------------------------
    public void ToggleXR() {
        if (XRSettings.loadedDeviceName.ToLower() == deviceName.ToLower()) {
            StartCoroutine(LoadDevice(deviceNone));
        } else {
            StartCoroutine(LoadDevice(deviceName));
        }
    }

    IEnumerator LoadDevice(string newDevice) {
        bool vrMode = newDevice != deviceNone;

        XRSettings.LoadDeviceByName(newDevice);
        yield return null;

        XRSettings.enabled = vrMode;
    }
}