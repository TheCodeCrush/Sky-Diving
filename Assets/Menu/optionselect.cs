using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class optionselect : MonoBehaviour
{
    public void SelectSnow ()
    {
        SceneManager.LoadScene(2);
    }
    public void SelectCity()
    {
        SceneManager.LoadScene(5);
    }
}
