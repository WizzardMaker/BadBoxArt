using UnityEngine;


public class PickupSprayer : MonoBehaviour {
  
  
  public Vector3 sprayVector;
  public int sprayAmount;
  public GameObject pickup;
  public float sprayTime;
  float sprayTimeSet;
  
  public void Update(){
    if(Time.time > sprayTimeSet){
      sprayTimeSet = sprayTime + Time.time;
      
      for(int i = 0; i <= sprayAmount; i++){
        GameObject temp = (GameObject)Instantiate(pickup,transform.position,Quaternion.identity);
        
        temp.GetComponent<Rigidbody>().AddForce(sprayVector);
      }
    }
  }
  
}