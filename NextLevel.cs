using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NextLevel : MonoBehaviour{

    public float tiempo = 5;

    void start()
    {
        StartCoroutine(Temp());
    }
        IEnumerator Temp()
    {
        yield return new WaitForSeconds(tiempo);
        SceneManager.LoadScene("VRPCongratulation");


    }
}
