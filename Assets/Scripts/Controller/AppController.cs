using UnityEngine;

public class AppController : MonoBehaviour
{
    
    public static AppController ApplicationController;

    public void Awake()
    {
        if (ApplicationController != null && ApplicationController != this)
        {
            Destroy(this);
        }
        else
        {
            ApplicationController = this;
            DontDestroyOnLoad(ApplicationController);
        }
    }
    public void Start()
    {
        
        //TODO : later --> get the save
    }
}
