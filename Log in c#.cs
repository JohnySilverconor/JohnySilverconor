using UnityEngine;

public class LoginScript : MonoBehaviour
{
    public GUISkin myskin;
    public float generalwidth = 20f;
    public float loaderHeight = 10f;
    public float loaderWidth = 10f;
    public float logHeight = 10f;
    public float logWidth = 10f;
    public string playerUserName = " ";
    public string PlayerPasswords = " ";
    public float UserHeight = 1f;
    public float PassHeight = 1f;
    public string GameOwner = "";
    public string GamePassword = "";
    public bool Usernamecorrect = false;
    public bool Passwordcorrect = false;

    private void Update()
    {
        if (playerUserName == GameOwner)
        {
            Usernamecorrect = true;
        }
        else
        {
            Usernamecorrect = false;
        }

        if (PlayerPasswords == GamePassword)
        {
            Passwordcorrect = true;
        }
        else
        {
            Passwordcorrect = false;
        }
    }

    private void OnGUI()
    {
        GUI.skin = myskin;

        // Background
        GUI.Box(new Rect(loaderHeight, loaderWidth, 220f, 120f), "Log in");

        // Text area
        playerUserName = GUI.TextArea(new Rect(generalwidth, UserHeight, 100f, 20f), playerUserName);
        PlayerPasswords = GUI.TextArea(new Rect(generalwidth, PassHeight, 100f, 20f), PlayerPasswords);

        if (GUI.Button(new Rect(logHeight, logWidth, 60f, 20f), "Log in"))
        {
            if (Usernamecorrect)
            {
                if (Passwordcorrect)
                {
                    Application.LoadLevel(0);
                }
            }
        }
    }
}
