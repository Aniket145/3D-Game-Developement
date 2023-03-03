using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
   public float damage=10f;
   public float range = 100f;
   public Camera c1;
   public ParticleSystem p1;
   AudioSource a1;
   public static int s1;
   public ParticleSystem p2;
   public ParticleSystem p3;

void Start()
{
a1 = GetComponent<AudioSource>();
}

// Update is called once per frame
void Update()
{
if (Input.GetButtonDown ("Fire1"))
{
Shoot ();
p1.Play();
a1.Play();
}
}
void Shoot (){
RaycastHit hit;

if (Physics.Raycast(c1.transform.position, c1.transform.forward, out hit, range))
{
   
   if(hit.transform.gameObject.CompareTag("Enemy")){
      Enemy_hp hp = hit.transform.GetComponent<Enemy_hp>();
      if( hp != null){

         hp.healthdamage(damage);
         p2.Play();
         s1= s1+20;
      }
   
   }
   else if (hit.transform.gameObject.CompareTag("Senemy"))
   {
      Destroy(hit.collider.gameObject);
      s1= s1+10;
   }
   else if(hit.transform.gameObject.CompareTag("BEnemy")){
      BEnemy_hp hp = hit.transform.GetComponent<BEnemy_hp>();
      if( hp != null){

         hp.healthdamage(damage);
         p3.Play();
         s1= s1+30;
      }
   }
}
}
    
}

