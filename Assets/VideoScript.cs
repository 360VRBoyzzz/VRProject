using UnityEngine;
using System.Collections;

public class VideoScript : MonoBehaviour {

    MovieTexture texture;


	// Use this for initialization
	void Start () {


        texture = (MovieTexture)GetComponent<Renderer>().material.mainTexture;
        texture.Play();
        texture.loop = true;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
