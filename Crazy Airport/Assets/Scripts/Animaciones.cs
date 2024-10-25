using UnityEngine;

public class Animaciones : MonoBehaviour
{
    public Animator animator; // Conectar aquí el Animator desde el Inspector

    // Funciones para activar las animaciones, deben ser públicas
    public void PlayArribaAnimation()
    {
        ResetTriggers();
        animator.SetTrigger("ArribaTrigger");
    }

    public void PlayMedArribaAnimation()
    {
        ResetTriggers();
        animator.SetTrigger("MedArribaTrigger");
    }

    public void PlayMedBajoAnimation()
    {
        ResetTriggers();
        animator.SetTrigger("MedBajoTrigger");
    }

    public void PlayBajoAnimation()
    {
        ResetTriggers();
        animator.SetTrigger("BajoTrigger");
    }

    private void ResetTriggers()
    {
        animator.ResetTrigger("ArribaTrigger");
        animator.ResetTrigger("MedArribaTrigger");
        animator.ResetTrigger("MedBajoTrigger");
        animator.ResetTrigger("BajoTrigger");
    }
}
