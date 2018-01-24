using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataInserter : MonoBehaviour {


    public Text rLogin;
    public Text rPassword;
    public Text rButton;

    public string inputUsername;
    public string inputPassword;
    
    private string createUserURL = "http://localhost/MultiPlatform/InsertUser.php";

	private void Update () {
        inputUsername = rLogin.text;
        inputPassword = rPassword.text;
	}

    public void Wrapper() {
        CreateUser(inputUsername, inputPassword);
        rButton.text = "Registered";
    }

    public void CreateUser(string username, string password) {
         
        WWWForm form = new WWWForm();
        form.AddField("usernamePost", username);
        form.AddField("passwordPost", password);

        WWW www = new WWW(createUserURL, form);
    }
}
