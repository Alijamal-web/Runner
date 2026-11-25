using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    [SerializeField]List<string> friends = new List<string>();

    void Start()
    {
        friends.Add("0");
        friends.Add("1");
        friends.Add("2");
        friends.Add("3");
        friends.Add("4");
        friends.Add("5");
        friends.Add("6");
        friends.Add("7");
        friends.Add("8");
        friends.Add("9");
        friends.Add("10");
        friends.Add("11");
        print(friends[0]);
        print(friends[1]);
        print(friends[2]);
        print(friends[3]);
        print(friends[4]);
        print(friends[5]);
        print(friends[6]);
        print(friends[7]);
        print(friends[8]);
        print(friends[9]);
        print(friends[10]);
        print(friends[11]);
       
        for (var i = 0; i < 21; i++)
        {
            print(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
