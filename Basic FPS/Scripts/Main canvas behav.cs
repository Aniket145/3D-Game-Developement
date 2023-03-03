using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


public class Canvas_text_behaviour : MonoBehaviour
{
bool tim = false;
float ctime;
int stime = 1;
public Text timtext;
public Text s;
void Start()
{
ctime = stime * 60;
tim =true;
}

// Update is called once per frame
void Update()
{
if (tim == true){
ctime = ctime - Time.deltaTime;
}
TimeSpan time = TimeSpan.FromSeconds(ctime);
timtext.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();

if ( time.Seconds ==0)
{
Debug.Log("Time over!!!");
SceneManager.LoadScene("GameOver");
}

s.text = "Score: " + Raycasting.s1; //raycasting is my script, s1 is score
}
}
