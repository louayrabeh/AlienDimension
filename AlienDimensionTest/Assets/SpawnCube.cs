using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour {

    public GameObject e1, x, p, e2, r, i, e3, n, c, e4;
    public Vector3 center;
    public Vector3 size;

    // Use this for initialization
    void Start () {
        SpawnOb();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void SpawnOb()
    {
        Vector3 pos1 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Vector3 pos2 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Vector3 pos3 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Vector3 pos4 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Vector3 pos5 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Vector3 pos6 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Vector3 pos7 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Vector3 pos8 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Vector3 pos9 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Vector3 pos10 = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(e1, pos1, Quaternion.identity);
        Instantiate(x, pos2, Quaternion.identity);
        Instantiate(p, pos3, Quaternion.identity);
        Instantiate(e2, pos4, Quaternion.identity);
        Instantiate(r, pos5, Quaternion.identity);
        Instantiate(i, pos6, Quaternion.identity);
        Instantiate(e3, pos7, Quaternion.identity);
        Instantiate(n, pos8, Quaternion.identity);
        Instantiate(c, pos9, Quaternion.identity);
        Instantiate(e4, pos10, Quaternion.identity);
    }
    public void OnDrawGizmosSelected()
    {
        //Gizmos.color=new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center,size);
    }
}
