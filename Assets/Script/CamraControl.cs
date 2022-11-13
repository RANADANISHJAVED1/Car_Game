using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraControl : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject vehical1;
    public GameObject vehical2;
    private Vector3 loc1 = new Vector3(0, 11, -23);
    private Vector3 loc2 = new Vector3(0, 11, -23);
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetButtonDown("1Key"))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        else if (Input.GetButtonDown("2Key"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        cam1.transform.position = vehical1.transform.position + loc1 ;
        cam2.transform.position = vehical2.transform.position + loc2;
    }
}
