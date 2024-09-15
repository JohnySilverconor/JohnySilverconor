// breakable objects

Using System.Collections;
Using System.Collections.Generic;
Using UnityEngine;

public class Crate : MonoBehaviour {
 SpriteRenderer rend;

 Shader hitShader;

public GameObject breakPrefab;

void Start(){
  rend = GetComponent<SpriteRenderer>();
	hitShader = Shader.Find("GUI/TextShader");

}

//hits Bullet prefab
void OnCollisionEnter2D()
{

if(other.gameObject.CompareTag("Bullet")
	{
	// Change Texture to white
	rend.material.shader = hitShader;
	rend.material.color = Color.white;
	findObjectOfType<HitStop>().Stop(0.1f);
	StartCoroutine(waitForSpawn());
	
	}
}

IEnumerator waitForSpawn()
	{
	while(Time.timeScale != 1.0f)
	yield return null;
	// Spawn Destroyed Object
	Instantiate(breakPrefab, transform.position, Quaternion.identify);
	Destroy(GameObject:
	}
}
