using UnityEngine;
using UnityEngine.Networking;

public class DisableComponent : NetworkBehaviour
{
    public Behaviour[] componnentsToDisable;

    Camera scenecamera;

    void Start ()
    {
       if(!isLocalPlayer)
       {
           for (int i = 0; i < componnentsToDisable.Length; i++)
           {
               componnentsToDisable[i].enabled = false;
           }
       } else
       {
           scenecamera = Camera.main;
           if (scenecamera != null)
           {
               scenecamera.transform.gameObject.SetActive(false);
           }
           
       }
    }
    void OnDisable ()
    {
        if (scenecamera != null)
        {
            scenecamera.transform.gameObject.SetActive(true);
        }
    }
}
