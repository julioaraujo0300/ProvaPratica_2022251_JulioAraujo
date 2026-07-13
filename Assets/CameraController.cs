using UnityEngine;
using Unity.Cinemachine;

public class CameraController : MonoBehaviour
{
    [Header("Virtual Cameras")]
    [SerializeField] CinemachineCamera geralCam;
    [SerializeField] CinemachineCamera terraCam;
    [SerializeField] CinemachineCamera luaCam;

    [Header("Configuração")]
    [SerializeField] int activePriority = 20;
    [SerializeField] int inactivePriority = 10;

    void Start()
    {
        SetActiveCamera(luaCam);
    }

 
    public void CameraGeral()  => SetActiveCamera(geralCam);
    public void CameraTerra() => SetActiveCamera(terraCam);
    public void CameraLua() => SetActiveCamera(luaCam);

    private void SetActiveCamera(CinemachineCamera activeCam)
    {
        geralCam.Priority = inactivePriority;
        terraCam.Priority = inactivePriority;
        luaCam.Priority = inactivePriority;


        activeCam.Priority = activePriority;
    }
}