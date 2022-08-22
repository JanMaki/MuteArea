
using UdonSharp;
using VRC.SDKBase;

public class MuteArea : UdonSharpBehaviour
{
    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        player.SetVoiceDistanceFar(0);
    }

    public override void OnPlayerTriggerStay(VRCPlayerApi player)
    {
        player.SetVoiceDistanceFar(0);
    }

    public override void OnPlayerTriggerExit(VRCPlayerApi player)
    {
        player.SetVoiceDistanceFar(25);
    }
}
