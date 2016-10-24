using UnityEngine;
using System.Collections;

public class brakeLights : MonoBehaviour {

  
    public GameObject brakeLightRight;
    public GameObject brakeLightLeft;
    public GameObject brakeGlassRight;
    public GameObject brakeGlassLeft;
    
    

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.Space))
        {
            
            brakeLightLeft.GetComponent<Light>().intensity = 0.2f;
            brakeLightRight.GetComponent<Light>().intensity = 0.2f;
            brakeGlassLeft.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);
            brakeGlassRight.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.red);

        }
        else
        {
            brakeLightLeft.GetComponent<Light>().intensity = 0f;
            brakeLightRight.GetComponent<Light>().intensity = 0f;
            brakeGlassLeft.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Color(0.5f, 0, 0));
            brakeGlassRight.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Color(0.5f, 0, 0));
        }
    }
}
