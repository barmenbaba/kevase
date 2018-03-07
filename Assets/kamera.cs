using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour {

    public Camera camerasag;
    public Camera camerasol;
    public Camera cameraon;

    public GameObject kamerabutsag;
    public GameObject kamerabutsol;
    public GameObject kamerasagonbut;
    public GameObject kamerasolonbut;

    // Use this for initialization
    void Start() {

        kamerasolonbut.SetActive(false);
        kamerasagonbut.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void sagcambut()
    {
        camerasag.enabled = true;
        cameraon.enabled = false;
        camerasol.enabled = false;
        kamerabutsag.SetActive(false);
        kamerasagonbut.SetActive(false);
        kamerasolonbut.SetActive(true);
        kamerabutsol.SetActive(false);
    }


    public void solcambut()
    {
        camerasag.enabled = false;
        cameraon.enabled = false;
        camerasol.enabled = true;
        kamerabutsag.SetActive(false);
        kamerasagonbut.SetActive(true);
        kamerasolonbut.SetActive(false);
        kamerabutsol.SetActive(false);
    }


    public void soloncambut()
    {
        camerasag.enabled = false;
        cameraon.enabled = true;
        camerasol.enabled = false;
        kamerabutsag.SetActive(true);
        kamerasagonbut.SetActive(false);
        kamerasolonbut.SetActive(false);
        kamerabutsol.SetActive(true);
    }

    public void sagoncambut()
    {
        camerasag.enabled = false;
        cameraon.enabled = true;
        camerasol.enabled = false;
        kamerabutsag.SetActive(true);
        kamerasagonbut.SetActive(false);
        kamerasolonbut.SetActive(false);
        kamerabutsol.SetActive(true);
    }





}
