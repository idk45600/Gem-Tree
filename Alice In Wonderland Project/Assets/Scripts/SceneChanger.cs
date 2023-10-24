using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static List<string> sceanes = new List<string>();




    public static SceneChanger instance;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (instance != null)
        {
            Debug.LogError("more then one referance to singleton");
            return;
        }
        instance = this;
    }

    private void Start()
    {
        sceanes.Add("maze");
        sceanes.Add("Chess");
        sceanes.Add("TeaParty");
      


    }
    public void loadNewScene()
    {
        int i = Random.Range(0, sceanes.Count);


        if (sceanes.Count == 0)
        {
            SceneManager.LoadScene(5);
        }


            SceneManager.LoadScene(sceanes[i]);
            //SceneManager.;

            sceanes.RemoveAt(i);

     
    }
    public void startgame()
    {
        SceneManager.LoadScene(1);
    }
    public void Quitgame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
       /* int i = Random.Range(0, sceanes.Count);

        if (Input.GetKeyDown(KeyCode.Space))
        {


            SceneManager.LoadScene(sceanes[i]);
            //SceneManager.;

            sceanes.RemoveAt(i);

        }*/
    }
}
