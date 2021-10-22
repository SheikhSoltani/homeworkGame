using UnityEngine;

public class Credits : MonoBehaviour
{
    void Start()
    {

        Cursor.lockState = CursorLockMode.None;
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    

}
