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

            string path = Application.streamingAssetsPath + "/Flyover.mp4";

            Debug.Log("PATH - " + path);
            player.url = path;
            player.Prepare();
            player.Play();

        }
	}

	
	
	// Update is called once per frame
	void Update () {
		
	}
}
