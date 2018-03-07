using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrol : MonoBehaviour {

    Animator anim;
    public bool kos_b, atak_b, skil_b;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
       
    }
	
	// Update is called once per frame
	void Update () {
      
    }

    void FixedUpdate() {
        anim.SetBool ("kos",kos_b);
        anim.SetBool ("atak", atak_b);
        anim.SetBool ("skil", skil_b);
    } 

    public void kos_ak() {
        kos_b = true;
     
    }

    public void kos_pas() {
        kos_b = false;
    }




    public void atak_ak()
    {
        atak_b = true;

    }

    public void atak_pas()
    {
        atak_b = false;
    }




    public void skil_ak()
    {
        skil_b = true;

    }

    public void skil_pas()
    {
        skil_b = false;
    }

}
