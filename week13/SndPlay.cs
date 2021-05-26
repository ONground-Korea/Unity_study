using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SndPlay : MonoBehaviour
{
    public AudioClip SndTree;
    public AudioClip SndRock;
    public AudioClip SndHouse;
    public AudioClip SndPlane;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision Detected)
    {
        if (Detected.gameObject.tag == "House")
        {
            GetComponent<AudioSource>().PlayOneShot(SndHouse, 1f);
        }
        else if (Detected.gameObject.tag == "Plane")
        {
            GetComponent<AudioSource>().PlayOneShot(SndPlane, 1f);
        }
        else if (Detected.gameObject.tag == "Tree")
        {
            GetComponent<AudioSource>().PlayOneShot(SndTree, 1f);
        }
        else if (Detected.gameObject.tag == "πŸ¿ß")
        {
            GetComponent<AudioSource>().PlayOneShot(SndRock, 1f);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
