using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.Netcode;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button Server_Btn;
    [SerializeField] private Button Host_Btn;
    [SerializeField] private Button Client_Btn;
    NetworkManager networkManager;

    private void Awake()
    {
        Server_Btn.onClick.AddListener(() => {
            NetworkManager.Singleton.StartServer(); });
        Host_Btn.onClick.AddListener(() => { NetworkManager.Singleton.StartHost(); });
        Client_Btn.onClick.AddListener(() => { NetworkManager.Singleton.StartClient(); });
    }
}
