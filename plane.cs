using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public GameObject bombs;

    private void Start()
    {
        if (Application.loadedLevel == 1)
        {
            GetComponent<Renderer>().material.color = new Color(
                PlayerPrefs.GetFloat("planeColorR"),
                PlayerPrefs.GetFloat("planeColorG"),
                PlayerPrefs.GetFloat("planeColorB"));
        }

        bombs.SetActive(false);
        if (PlayerPrefs.GetInt("planeBombs") == 1)
        {
            bombs.SetActive(true);
        }
    }

    private void OnGUI()
    {
        if (Application.loadedLevel == 0)
        {
            if (GUI.Button(new Rect(10, 10, 100, 50), "Red"))
            {
                GetComponent<Renderer>().material.color = Color.red;
            }

            if (GUI.Button(new Rect(10, 70, 100, 50), "Blue"))
            {
                GetComponent<Renderer>().material.color = Color.blue;
            }

            if (GUI.Button(new Rect(10, 130, 100, 50), "Green"))
            {
                GetComponent<Renderer>().material.color = Color.green;
            }

            if (GUI.Button(new Rect(10, 190, 100, 50), "Bombs"))
            {
                bombs.SetActive(!bombs.activeSelf);
            }

            if (GUI.Button(new Rect(120, 10, 100, 50), "Load Level"))
            {
                PlayerPrefs.SetFloat("planeColorR", GetComponent<Renderer>().material.color.r);
                PlayerPrefs.SetFloat("planeColorG", GetComponent<Renderer>().material.color.g);
                PlayerPrefs.SetFloat("planeColorB", GetComponent<Renderer>().material.color.b);

                if (bombs.activeSelf)
                {
                    PlayerPrefs.SetInt("planeBombs", 1);
                }
                else
                {
                    PlayerPrefs.SetInt("planeBombs", 0);
                }

                Application.LoadLevel(1);
            }
        }
        else
        {
            if (GUI.Button(new Rect(10, 10, 100, 50), "Load Menu"))
            {
                Application.LoadLevel(0);
            }
        }
    }
}

/*#pragma strict

var bombs: GameObject;

function Start()
{
	if(Application.loadedLevel == 1)
	{
		renderer.material.color.r = PlayerPrefs.GetFloat("planeColorR");
		renderer.material.color.g = PlayerPrefs.GetFloat("planeColorG");
		renderer.material.color.b = PlayerPrefs.GetFloat("planeColorB");
	}
	
	bombs.SetActive(false);
	if(PlayerPrefs.GetInt("planeBombs") == 1)
	{
		bombs.SetActive(true);
	}
}

function OnGUI()
{
	if(Application.loadedLevel == 0)
	{
		if(GUI.Button(Rect(10, 10, 100, 50), "Red"))
		{	
			renderer.material.color = Color.red;
		}
		
		if(GUI.Button(Rect(10, 70, 100, 50), "Blue"))
		{
			renderer.material.color = Color.blue;
		}
		
		if(GUI.Button(Rect(10, 130, 100, 50), "Green"))
		{
			renderer.material.color = Color.green;
		}
		
		if(GUI.Button(Rect(10, 190, 100, 50), "Bombs"))
		{
			bombs.SetActive(!bombs.activeSelf);
		}
		
		if(GUI.Button(Rect(120, 10, 100, 50), "Load Level"))
		{
			PlayerPrefs.SetFloat("planeColorR", renderer.material.color.r);
			PlayerPrefs.SetFloat("planeColorG", renderer.material.color.g);
			PlayerPrefs.SetFloat("planeColorB", renderer.material.color.b);
			
			if(bombs.activeSelf)
			{
				PlayerPrefs.SetInt("planeBombs", 1);
			}
			else
			{
				PlayerPrefs.SetInt("planeBombs", 0);
			}
		
			Application.LoadLevel(1);
		}
	}
	else
	{
		if(GUI.Button(Rect(10, 10, 100, 50), "Load Menu"))
		{	
			Application.LoadLevel(0);
		}
	}
}
*/