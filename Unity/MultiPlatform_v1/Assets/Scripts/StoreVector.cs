using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreVector : MonoBehaviour {

    public int x_pos;
    public int y_pos;
    public int z_pos;
    private string storeVectorURL = "http://localhost/MultiPlatform/StoreVector.php";

    // Use this for initialization
    void Update() {
        if (Input.GetKeyDown(KeyCode.V)) Store(x_pos, y_pos, z_pos);

        x_pos = Mathf.RoundToInt(CubeController.x_pos);
        y_pos = Mathf.RoundToInt(CubeController.y_pos);
        z_pos = Mathf.RoundToInt(CubeController.z_pos);
    }

    public void StoreWrapper() {
        Store(x_pos, y_pos, z_pos);
    }

    public void Store(int x, int y, int z) {
        WWWForm form = new WWWForm();
        form.AddField("xPost", x);
        form.AddField("yPost", y);
        form.AddField("zPost", z);

        WWW www = new WWW(storeVectorURL, form);
    }
}
