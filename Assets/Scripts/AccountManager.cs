using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HmsPlugin;
using HuaweiMobileServices.Id;
using HuaweiMobileServices.Utils;

public class AccountManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HMSAccountKitManager.Instance.OnSignInSuccess = SignInSuccess;
        HMSAccountKitManager.Instance.OnSignInFailed = SignInFailed;
        HMSAccountKitManager.Instance.SignIn();

        
    }

    private void SignInSuccess(AuthAccount account)
    {
        Debug.Log("OnLoginSuccess User Name: " + account.DisplayName);
    }

    private void SignInFailed(HMSException exception)
    {
        Debug.Log("SignInFailed. exception details:  " + exception.Message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
