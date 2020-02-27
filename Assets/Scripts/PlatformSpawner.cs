using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    
    public GameObject platform;

    Vector3 lastPos;
    float size;


    // Start is called before the first frame update
    void Start()
    {
        lastPos = platform.transform.position;
        size = platform.transform.localScale.x;

        for(int i = 0; i < 5; i++){
        	SpawnZ();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnX(){
    	Vector3 pos = lastPos;
    	pos.x += size;
    	lastPos = pos;
    	Instantiate (platform, pos, Quaternion.identity);
    }

    void SpawnZ(){
    	Vector3 pos = lastPos;
    	pos.z += size;
    	lastPos = pos;
    	Instantiate (platform, pos, Quaternion.identity);
    }

}
