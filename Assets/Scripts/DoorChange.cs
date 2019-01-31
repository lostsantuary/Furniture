using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorChange : MonoBehaviour {

    public Sprite[] s1;
    public Button DButt;

    int count = 0;

    void Awake()
    {
        s1 = Resources.LoadAll<Sprite>("Sprites");
        foreach(Sprite s in s1)
        {
            print(s.name);
        }
    }

    public void On_Click_Button()
    {
        count++;

        if (count == s1.Length)
        {
            count = 0;
        }
        //print(count);
        DButt.image.sprite = s1 [count];
        //print(DButt.image.sprite.name);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
