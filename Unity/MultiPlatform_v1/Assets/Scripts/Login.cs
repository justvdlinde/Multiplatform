using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Login : MonoBehaviour {

    public Text lLogin;
    public Text lPassword;
    public Text lButton;

    public int x_pos;
    public int y_pos;
    public int z_pos;

    public string inputUsername;
    public string inputPassword;

    private string loginURL = "http://localhost/MultiPlatform/Login.php";

	void Update () {
        inputUsername = lLogin.text;
        inputPassword = lPassword.text;
    }

    public void Wrapper() {
        StartCoroutine(LoginToDB(inputUsername, inputPassword));
        lButton.text = "Logged In";
    }

    private IEnumerator LoginToDB(string username, string password) {
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("passwordPost", password);

        WWW www = new WWW(loginURL, form);
        
        yield return www;
        
        Debug.Log(www.text);
        if (www.text.Contains ("login success")) { SceneManager.LoadScene("Game"); }
        else lButton.text = "Login Failed";
    }
}
