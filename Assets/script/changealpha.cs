using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changealpha : MonoBehaviour
{
    public float start;
    public float end;
    public Transform player;
    float alphaLevel = .0f;
    float xPos;

    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xPos = player.transform.position.x;
        Debug.Log(xPos);
        if(xPos>=end-10) alphaLevel = ((end-xPos)*.1f);
        else if(xPos>=start) alphaLevel = ((xPos-start)*.1f);
        GetComponent<SpriteRenderer>().color = new Color(1,1,1,alphaLevel);
    }
}
