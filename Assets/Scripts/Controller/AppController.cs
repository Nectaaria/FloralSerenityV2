using UnityEngine;

public class AppController : MonoBehaviour
{
    
    public static AppController ApplicationController;
    public SoundManager SoundManagerInstance;

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
        SoundManagerInstance.PlayMainMusic();
        //TODO : later --> get the save
    }
}
