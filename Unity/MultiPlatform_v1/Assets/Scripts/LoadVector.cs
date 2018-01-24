using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadVector : MonoBehaviour {

    public string[] vectors;

    private IEnumerator Start () {
	    WWW vectorData = new WWW("http://localhost/MultiPlatform/LoadVector.php");

        yield return vectorData;

        string vectorDataString = vectorData.text;
        vectors = vectorDataString.Split(';');
        print(GetDataValue(vectors[0], ""));
    }

    private string GetDataValue(string data, string index) {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if(value.Contains("|"))value = value.Remove(value.IndexOf("|"));
        return value;
    }
}
