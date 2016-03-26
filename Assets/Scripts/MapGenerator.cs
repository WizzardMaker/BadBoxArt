using UnityEngine;

public class MapGenerator : Monobehaviour{
 
  public enum MapTypes{
    Farm,
    House,
    Flat,
  }
  
  public int mapSize;
  public float mapScale;
  
  
  public GameObject roadPrefab;
  public GameObject[] mapPrefabs; 
  public MapTypes map[,];
  
  void Start(){
    map = new MapTypes[mapSize,mapSize]();
    
    for(int x = 0; x < mapSize; x++){
      for(int y = 0; y < mapSize; y++){
        map[x,y] = (MapTypes)Random.Range(0,2);
        
        Instantiate(mapPrefabs[(int)map[x,y]],new Vector3(x,y,0) *mapScale, Quaternion.identity);
        
        Instantiate(roadPrefab, new Vector3(x,y,0) *mapScale, Quaternion.identity);
      }
    }
  }
  
  
  
}