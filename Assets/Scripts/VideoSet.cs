using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSet : MonoBehaviour {

    VideoPlayer player;

	private void Awake()
	{
        player = transform.GetComponent<VideoPlayer>();
        if (player != null){

            string path = Application.streamingAssetsPath + "/M3.mp4";

            Debug.Log("PATH - " + path);
            player.url = path;
            player.Prepare();
            player.Play();

            //Application.targetFrameRate = 60;

        }
	}


	private void Start()
	{
        
	}

	// Update is called once per frame
	void Update () {
        
        //Debug.Log("Player FR - " + player.frameRate);
	}
}
