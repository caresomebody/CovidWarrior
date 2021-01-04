using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject bg;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    void Start(){
        player = GameObject.FindGameObjectWithTag("Player");
        bg = GameObject.FindGameObjectWithTag("Background");
    }

    // Update is called once per frame
    void LateUpdate(){
        float x=Mathf.Clamp(player.transform.position.x, xMin, xMax);
        float y=Mathf.Clamp(player.transform.position.y, yMin, yMax);
        gameObject.transform.position=new Vector3(x,y,gameObject.transform.position.z);
        bg.transform.position=new Vector2(transform.position.x * 1.0f, bg.transform.position.y);
    }
}
