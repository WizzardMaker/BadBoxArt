using UnityEngine;


public class PickupSprayer : MonoBehaviour {

	public int sprayBursts;
	int sprays;
  public Vector3 sprayVector;
  public int sprayAmount;
  public GameObject pickup;
  public float sprayTime;
  float sprayTimeSet;
  
  public void Update(){
		if(sprays >= sprayBursts) {
			sprays = 0;
			enabled = false;
			return;
		}

    if(Time.time > sprayTimeSet){
      sprayTimeSet = sprayTime + Time.time;
			sprays++;
      for(int i = 1; i <= sprayAmount; i++){
        GameObject temp = (GameObject)Instantiate(pickup,transform.position,Quaternion.identity);
        
        temp.GetComponent<Rigidbody>().AddForce(sprayVector,ForceMode.VelocityChange);
      }
    }
  }
  
}